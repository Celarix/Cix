﻿using System;
using System.Collections.Generic;
using System.Linq;
using Celarix.Cix.Compiler.Common;
using Celarix.Cix.Compiler.Emit.IronArc.Models.TypedExpressions;
using Celarix.Cix.Compiler.Extensions;
using Celarix.Cix.Compiler.Parse.Models.AST.v1;
using NLog;

namespace Celarix.Cix.Compiler.Emit.IronArc.Models.EmitStatements
{
    internal sealed class Function : EmitStatement
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        
        public Parse.Models.AST.v1.Function ASTFunction { get; set; }

        public override GeneratedFlow Generate(EmitContext context, EmitStatement parent)
        {
            if (ASTFunction.ReturnType is NamedDataType namedType && namedType.Name == "void" && ASTFunction.ReturnType.PointerLevel == 0)
            {
                ASTFunction.Statements.Add(new Parse.Models.AST.v1.ReturnStatement());
            }
            else if (!ASTFunction.Statements.Any())
            {
                throw new InvalidOperationException("Function doesn't return");
            }
            else
            {
                var lastStatement = ASTFunction.Statements.Last();
                var isLastStatementAReturn = lastStatement is Parse.Models.AST.v1.ReturnStatement;

                if (isLastStatementAReturn)
                {
                    var returnStatement = lastStatement as Parse.Models.AST.v1.ReturnStatement;

                    if (returnStatement.ReturnValue == null)
                    {
                        throw new InvalidOperationException("Function doesn't end in return");
                    }
                }
            }
            
            context.CurrentFunction = ASTFunction;
            foreach (var argument in ASTFunction.Parameters)
            {
                context.CurrentStack.Push(new VirtualStackEntry(argument.Name, context.LookupDataTypeWithPointerLevel(argument.Type)));
                logger.Trace($"Pushed argument {argument.Name} at EBP+{context.CurrentStack.Peek().OffsetFromEBP}");
            }
            
            var statementBuilder = new EmitStatementBuilder(context);
            var emitStatements = ASTFunction.Statements.Select(f => statementBuilder.Build(f)).ToList();
            var statementFlows = emitStatements.Select(s => s.Generate(context, this)).ToList();

            foreach (var (current, next) in statementFlows.Pairwise())
            {
                var currentAfterJumps =
                    current.UnconnectedJumps.Where(j => j.TargetType == JumpTargetType.ToAfterTarget);
                var currentBreakJumps =
                    current.UnconnectedJumps.Where(j => j.TargetType == JumpTargetType.ToBreakTarget);

                var breakAfterTarget = next?.ControlFlow.Start; // Don't worry if
                // next is null - if it is, we'll always be on a return statement
                // (or the code is wrong, anyway), and return statements never
                // have jumps.

                // After targets
                foreach (var jump in currentAfterJumps)
                {
                    logger.Trace($"Connected after target inside function");
                    breakAfterTarget.IsJumpTarget = true;
                    jump.SourceVertex.ConnectTo(breakAfterTarget, jump.FlowType);
                }

                current.UnconnectedJumps.RemoveAll(j => j.TargetType == JumpTargetType.ToAfterTarget);

                // Break targets
                var breakTarget = next?.ControlFlow.Start;

                foreach (var jump in currentBreakJumps)
                {
                    if (breakAfterTarget == null)
                    {
                        throw new InvalidOperationException(
                            "Statement broke out to a place after the end of the function");
                    }

                    logger.Trace($"Connected break target inside function");
                    breakAfterTarget.IsJumpTarget = true;
                    jump.SourceVertex.ConnectTo(breakAfterTarget, jump.FlowType);
                }

                current.UnconnectedJumps.RemoveAll(j => j.TargetType == JumpTargetType.ToBreakTarget);
            }

            context.CurrentStack.Clear();

            return new GeneratedFlow
            {
                ControlFlow = EmitHelpers.ConnectWithDirectFlow(statementFlows.Select(sf => sf.ControlFlow))
            };
        }
    }
}