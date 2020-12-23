//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Documents\GitHub\Cix\antlrTest\Cix.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

namespace Cix.AST.ANTLR4
{
    /// <summary>
    /// This interface defines a complete listener for a parse tree produced by
    /// <see cref="CixParser"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
    [System.CLSCompliant(false)]
    public interface ICixListener : IParseTreeListener
    {
        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.primaryExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterPrimaryExpression([NotNull] CixParser.PrimaryExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.primaryExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitPrimaryExpression([NotNull] CixParser.PrimaryExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.postfixExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterPostfixExpression([NotNull] CixParser.PostfixExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.postfixExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitPostfixExpression([NotNull] CixParser.PostfixExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.argumentExpressionList"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterArgumentExpressionList([NotNull] CixParser.ArgumentExpressionListContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.argumentExpressionList"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitArgumentExpressionList([NotNull] CixParser.ArgumentExpressionListContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.unaryExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterUnaryExpression([NotNull] CixParser.UnaryExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.unaryExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitUnaryExpression([NotNull] CixParser.UnaryExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.unaryOperator"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterUnaryOperator([NotNull] CixParser.UnaryOperatorContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.unaryOperator"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitUnaryOperator([NotNull] CixParser.UnaryOperatorContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.castExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterCastExpression([NotNull] CixParser.CastExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.castExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitCastExpression([NotNull] CixParser.CastExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.multiplicativeExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterMultiplicativeExpression([NotNull] CixParser.MultiplicativeExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.multiplicativeExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitMultiplicativeExpression([NotNull] CixParser.MultiplicativeExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.additiveExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterAdditiveExpression([NotNull] CixParser.AdditiveExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.additiveExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitAdditiveExpression([NotNull] CixParser.AdditiveExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.shiftExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterShiftExpression([NotNull] CixParser.ShiftExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.shiftExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitShiftExpression([NotNull] CixParser.ShiftExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.relationalExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterRelationalExpression([NotNull] CixParser.RelationalExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.relationalExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitRelationalExpression([NotNull] CixParser.RelationalExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.equalityExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterEqualityExpression([NotNull] CixParser.EqualityExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.equalityExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitEqualityExpression([NotNull] CixParser.EqualityExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.andExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterAndExpression([NotNull] CixParser.AndExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.andExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitAndExpression([NotNull] CixParser.AndExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.exclusiveOrExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterExclusiveOrExpression([NotNull] CixParser.ExclusiveOrExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.exclusiveOrExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitExclusiveOrExpression([NotNull] CixParser.ExclusiveOrExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.inclusiveOrExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterInclusiveOrExpression([NotNull] CixParser.InclusiveOrExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.inclusiveOrExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitInclusiveOrExpression([NotNull] CixParser.InclusiveOrExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.logicalAndExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterLogicalAndExpression([NotNull] CixParser.LogicalAndExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.logicalAndExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitLogicalAndExpression([NotNull] CixParser.LogicalAndExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.logicalOrExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterLogicalOrExpression([NotNull] CixParser.LogicalOrExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.logicalOrExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitLogicalOrExpression([NotNull] CixParser.LogicalOrExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.conditionalExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterConditionalExpression([NotNull] CixParser.ConditionalExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.conditionalExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitConditionalExpression([NotNull] CixParser.ConditionalExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.assignmentExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterAssignmentExpression([NotNull] CixParser.AssignmentExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.assignmentExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitAssignmentExpression([NotNull] CixParser.AssignmentExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.assignmentOperator"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterAssignmentOperator([NotNull] CixParser.AssignmentOperatorContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.assignmentOperator"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitAssignmentOperator([NotNull] CixParser.AssignmentOperatorContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.expression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterExpression([NotNull] CixParser.ExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.expression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitExpression([NotNull] CixParser.ExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.constantExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterConstantExpression([NotNull] CixParser.ConstantExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.constantExpression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitConstantExpression([NotNull] CixParser.ConstantExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.typeName"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterTypeName([NotNull] CixParser.TypeNameContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.typeName"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitTypeName([NotNull] CixParser.TypeNameContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.funcptrTypeName"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterFuncptrTypeName([NotNull] CixParser.FuncptrTypeNameContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.funcptrTypeName"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitFuncptrTypeName([NotNull] CixParser.FuncptrTypeNameContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.typeNameList"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterTypeNameList([NotNull] CixParser.TypeNameListContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.typeNameList"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitTypeNameList([NotNull] CixParser.TypeNameListContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.primitiveType"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterPrimitiveType([NotNull] CixParser.PrimitiveTypeContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.primitiveType"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitPrimitiveType([NotNull] CixParser.PrimitiveTypeContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.pointerAsteriskList"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterPointerAsteriskList([NotNull] CixParser.PointerAsteriskListContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.pointerAsteriskList"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitPointerAsteriskList([NotNull] CixParser.PointerAsteriskListContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.variableDeclarationStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterVariableDeclarationStatement([NotNull] CixParser.VariableDeclarationStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.variableDeclarationStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitVariableDeclarationStatement([NotNull] CixParser.VariableDeclarationStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.variableDeclarationWithInitializationStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterVariableDeclarationWithInitializationStatement(
            [NotNull] CixParser.VariableDeclarationWithInitializationStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.variableDeclarationWithInitializationStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitVariableDeclarationWithInitializationStatement(
            [NotNull] CixParser.VariableDeclarationWithInitializationStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.struct"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterStruct([NotNull] CixParser.StructContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.struct"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitStruct([NotNull] CixParser.StructContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.structMember"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterStructMember([NotNull] CixParser.StructMemberContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.structMember"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitStructMember([NotNull] CixParser.StructMemberContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.structArraySize"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterStructArraySize([NotNull] CixParser.StructArraySizeContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.structArraySize"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitStructArraySize([NotNull] CixParser.StructArraySizeContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.globalVariableDeclaration"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterGlobalVariableDeclaration([NotNull] CixParser.GlobalVariableDeclarationContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.globalVariableDeclaration"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitGlobalVariableDeclaration([NotNull] CixParser.GlobalVariableDeclarationContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.function"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterFunction([NotNull] CixParser.FunctionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.function"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitFunction([NotNull] CixParser.FunctionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.functionParameterList"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterFunctionParameterList([NotNull] CixParser.FunctionParameterListContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.functionParameterList"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitFunctionParameterList([NotNull] CixParser.FunctionParameterListContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.functionParameter"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterFunctionParameter([NotNull] CixParser.FunctionParameterContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.functionParameter"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitFunctionParameter([NotNull] CixParser.FunctionParameterContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterStatement([NotNull] CixParser.StatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitStatement([NotNull] CixParser.StatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.block"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterBlock([NotNull] CixParser.BlockContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.block"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitBlock([NotNull] CixParser.BlockContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.breakStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterBreakStatement([NotNull] CixParser.BreakStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.breakStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitBreakStatement([NotNull] CixParser.BreakStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.conditionalStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterConditionalStatement([NotNull] CixParser.ConditionalStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.conditionalStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitConditionalStatement([NotNull] CixParser.ConditionalStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.continueStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterContinueStatement([NotNull] CixParser.ContinueStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.continueStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitContinueStatement([NotNull] CixParser.ContinueStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.elseStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterElseStatement([NotNull] CixParser.ElseStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.elseStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitElseStatement([NotNull] CixParser.ElseStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.doWhileStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterDoWhileStatement([NotNull] CixParser.DoWhileStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.doWhileStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitDoWhileStatement([NotNull] CixParser.DoWhileStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.expressionStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterExpressionStatement([NotNull] CixParser.ExpressionStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.expressionStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitExpressionStatement([NotNull] CixParser.ExpressionStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.forStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterForStatement([NotNull] CixParser.ForStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.forStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitForStatement([NotNull] CixParser.ForStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.returnStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterReturnStatement([NotNull] CixParser.ReturnStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.returnStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitReturnStatement([NotNull] CixParser.ReturnStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.switchStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterSwitchStatement([NotNull] CixParser.SwitchStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.switchStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitSwitchStatement([NotNull] CixParser.SwitchStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.caseStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterCaseStatement([NotNull] CixParser.CaseStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.caseStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitCaseStatement([NotNull] CixParser.CaseStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.literalCaseStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterLiteralCaseStatement([NotNull] CixParser.LiteralCaseStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.literalCaseStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitLiteralCaseStatement([NotNull] CixParser.LiteralCaseStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.defaultCaseStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterDefaultCaseStatement([NotNull] CixParser.DefaultCaseStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.defaultCaseStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitDefaultCaseStatement([NotNull] CixParser.DefaultCaseStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.whileStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterWhileStatement([NotNull] CixParser.WhileStatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.whileStatement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitWhileStatement([NotNull] CixParser.WhileStatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.number"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterNumber([NotNull] CixParser.NumberContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.number"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitNumber([NotNull] CixParser.NumberContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="CixParser.sourceFile"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterSourceFile([NotNull] CixParser.SourceFileContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="CixParser.sourceFile"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitSourceFile([NotNull] CixParser.SourceFileContext context);
    }
}