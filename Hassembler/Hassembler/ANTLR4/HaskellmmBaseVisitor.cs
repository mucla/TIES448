//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Haskellmm.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IHaskellmmVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class HaskellmmBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IHaskellmmVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="HaskellmmParser.prog"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProg([NotNull] HaskellmmParser.ProgContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>refVar</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRefVar([NotNull] HaskellmmParser.RefVarContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>intVar</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIntVar([NotNull] HaskellmmParser.IntVarContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>multExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMultExp([NotNull] HaskellmmParser.MultExpContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>compExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCompExp([NotNull] HaskellmmParser.CompExpContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>parenExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitParenExp([NotNull] HaskellmmParser.ParenExpContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>addExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAddExp([NotNull] HaskellmmParser.AddExpContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>iteExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIteExp([NotNull] HaskellmmParser.IteExpContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="HaskellmmParser.f_defi"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitF_defi([NotNull] HaskellmmParser.F_defiContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="HaskellmmParser.ite_defi"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIte_defi([NotNull] HaskellmmParser.Ite_defiContext context) { return VisitChildren(context); }
}
