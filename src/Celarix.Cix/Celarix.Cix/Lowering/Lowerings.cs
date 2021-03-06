﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Celarix.Cix.Compiler.Parse.Models.AST.v1;
using NLog;

namespace Celarix.Cix.Compiler.Lowering
{
    internal static class Lowerings
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static void PerformLowerings(SourceFileRoot sourceFile)
        {
            logger.Debug("Performing lowerings...");

            var definedTypes = GetDefinedTypes(sourceFile.Structs);

            sourceFile.Functions.Add(GenerateGlobalAssignments(sourceFile.GlobalVariableDeclarations
                .Where(g => g is GlobalVariableDeclarationWithInitialization)
                .Cast<GlobalVariableDeclarationWithInitialization>()));

            foreach (var function in sourceFile.Functions)
            {
                for (int i = 0; i < function.Statements.Count; i++)
                {
                    function.Statements[i] = DisambiguateAsterisksInStatement(function.Statements[i], definedTypes);
                    function.Statements[i] = RewriteForLoopsInStatement(function.Statements[i]);
                }
            }
            
            logger.Debug("Lowerings performed");
        }

        private static Function GenerateGlobalAssignments(IEnumerable<GlobalVariableDeclarationWithInitialization> globals)
        {
            var function = new Function
            {
                Name = "__globals_init",
                Parameters = new List<FunctionParameter>(),
                ReturnType = new NamedDataType { Name = "void", PointerLevel = 0 },
                Statements = new List<Statement>()
            };

            foreach (var global in globals)
            {
                function.Statements.Add(new ExpressionStatement
                {
                    Expression = new BinaryExpression
                    {
                        Left = new Identifier
                        {
                            IdentifierText = global.Name
                        },
                        Operator = "=",
                        Right = global.Initializer
                    }
                });
            }

            logger.Trace("Generated function to assign global variables...");
            return function;
        }
        
        private static Statement DisambiguateAsterisksInStatement(Statement statement, IList<string> definedTypes)
        {
            switch (statement)
            {
                case Block block:
                {
                    for (int i = 0; i < block.Statements.Count; i++)
                    {
                        block.Statements[i] = DisambiguateAsterisksInStatement(block.Statements[i], definedTypes);
                    }

                    break;
                }
                case CaseStatement caseStatement:
                    caseStatement.Statement = DisambiguateAsterisksInStatement(caseStatement.Statement, definedTypes);

                    break;
                case ConditionalStatement conditionalStatement:
                {
                    conditionalStatement.IfTrue = DisambiguateAsterisksInStatement(conditionalStatement.IfTrue, definedTypes);

                    if (conditionalStatement.IfFalse != null)
                    {
                        conditionalStatement.IfFalse = DisambiguateAsterisksInStatement(conditionalStatement.IfFalse, definedTypes);
                    }

                    break;
                }
                case DoWhileStatement doWhileStatement:
                    doWhileStatement.LoopStatement = DisambiguateAsterisksInStatement(doWhileStatement.LoopStatement, definedTypes);

                    break;
                case ExpressionStatement expressionStatement:
                {
                    if (expressionStatement.Expression is BinaryExpression binaryExpression
                        && binaryExpression.Operator == "*"
                        && binaryExpression.Left is Identifier left
                        && binaryExpression.Right is Identifier right
                        && definedTypes.Any(t => left.IdentifierText == t))
                    {
                        logger.Trace($"Found expression that was actually a variable declaration: {expressionStatement.PrettyPrint(0)}");
                        return new VariableDeclaration
                        {
                            Type = new NamedDataType
                            {
                                Name = left.IdentifierText, PointerLevel = 1
                            },
                            Name = right.IdentifierText
                        };
                    }

                    break;
                }
                case ForStatement forStatement:
                    forStatement.LoopStatement = DisambiguateAsterisksInStatement(forStatement.LoopStatement, definedTypes);

                    break;
                case VariableDeclaration variableDeclaration:
                {
                    if (variableDeclaration.Type is NamedDataType namedDataType
                        && variableDeclaration.Type.PointerLevel == 1
                        && definedTypes.All(t => namedDataType.Name != t))
                    {
                        logger.Trace($"Found variable declaration that was actually an expression: {variableDeclaration.PrettyPrint(0)}");
                        return new ExpressionStatement
                        {
                            Expression = new BinaryExpression
                            {
                                Left = new Identifier
                                {
                                    IdentifierText = namedDataType.Name
                                },
                                Operator = "*",
                                Right = new Identifier
                                {
                                    IdentifierText = variableDeclaration.Name
                                }
                            }
                        };
                    }

                    break;
                }
                case WhileStatement whileStatement:
                    whileStatement.LoopStatement = DisambiguateAsterisksInStatement(whileStatement.LoopStatement, definedTypes);

                    break;
                case SwitchStatement switchStatement:
                    foreach (var caseStatement in switchStatement.Cases)
                    {
                        DisambiguateAsterisksInStatement(caseStatement, definedTypes);
                    }

                    break;
            }

            return statement;
        }

        private static Statement RewriteForLoopsInStatement(Statement statement)
        {
            switch (statement)
            {
                case Block block:
                {
                    for (int i = 0; i < block.Statements.Count; i++)
                    {
                        block.Statements[i] = RewriteForLoopsInStatement(block.Statements[i]);
                    }

                    break;
                }
                case CaseStatement caseStatement:
                    caseStatement.Statement = RewriteForLoopsInStatement(caseStatement.Statement);

                    break;
                case ConditionalStatement conditionalStatement:
                {
                    conditionalStatement.IfTrue = RewriteForLoopsInStatement(conditionalStatement.IfTrue);

                    if (conditionalStatement.IfFalse != null)
                    {
                        conditionalStatement.IfFalse = RewriteForLoopsInStatement(conditionalStatement.IfFalse);
                    }

                    break;
                }
                case DoWhileStatement doWhileStatement:
                    doWhileStatement.LoopStatement = RewriteForLoopsInStatement(doWhileStatement.LoopStatement);

                    break;
                case ForStatement forStatement:
                    // for (i = 0; i < 10; i++) statement();
                    // becomes
                    // { i = 0; while (i < 10) { statement(); i++; } }
                    logger.Trace(
                        $"Rewrote for loop into while loop: for ({forStatement.Initializer.PrettyPrint()}; {forStatement.Condition.PrettyPrint()}; {forStatement.Iterator.PrettyPrint()})");
                    return new Block
                    {
                        Statements = new List<Statement>
                        {
                            new ExpressionStatement
                            {
                                Expression = forStatement.Initializer
                            },
                            new WhileStatement
                            {
                                Condition = forStatement.Condition,
                                LoopStatement = new Block
                                {
                                    Statements = new List<Statement>
                                    {
                                        forStatement.LoopStatement,
                                        new ExpressionStatement
                                        {
                                            Expression = forStatement.Iterator
                                        }
                                    }
                                }
                            }
                        } 
                    };
                case WhileStatement whileStatement:
                    whileStatement.LoopStatement = RewriteForLoopsInStatement(whileStatement.LoopStatement);

                    break;
                case SwitchStatement switchStatement:
                    foreach (var caseStatement in switchStatement.Cases)
                    {
                        RewriteForLoopsInStatement(caseStatement);
                    }

                    break;
            }

            return statement;
        }

        private static IList<string> GetDefinedTypes(IEnumerable<Struct> structs)
        {
            return new List<string>
                {
                    "byte",
                    "sbyte",
                    "short",
                    "ushort",
                    "int",
                    "uint",
                    "long",
                    "ulong",
                    "float",
                    "double",
                    "void"
                }
                .Concat(structs.Select(s => s.Name))
                .ToList();
        }
    }
}
