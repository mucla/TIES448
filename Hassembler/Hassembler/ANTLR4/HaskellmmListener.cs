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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="HaskellmmParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public interface IHaskellmmListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="HaskellmmParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] HaskellmmParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HaskellmmParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] HaskellmmParser.ProgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="HaskellmmParser.referenceExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReferenceExp([NotNull] HaskellmmParser.ReferenceExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HaskellmmParser.referenceExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReferenceExp([NotNull] HaskellmmParser.ReferenceExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>refVar</c>
	/// labeled alternative in <see cref="HaskellmmParser.param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRefVar([NotNull] HaskellmmParser.RefVarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>refVar</c>
	/// labeled alternative in <see cref="HaskellmmParser.param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRefVar([NotNull] HaskellmmParser.RefVarContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exp</c>
	/// labeled alternative in <see cref="HaskellmmParser.param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExp([NotNull] HaskellmmParser.ExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exp</c>
	/// labeled alternative in <see cref="HaskellmmParser.param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExp([NotNull] HaskellmmParser.ExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>boolVar</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolVar([NotNull] HaskellmmParser.BoolVarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>boolVar</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolVar([NotNull] HaskellmmParser.BoolVarContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>intVar</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntVar([NotNull] HaskellmmParser.IntVarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>intVar</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntVar([NotNull] HaskellmmParser.IntVarContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>multExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultExp([NotNull] HaskellmmParser.MultExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultExp([NotNull] HaskellmmParser.MultExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>compExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompExp([NotNull] HaskellmmParser.CompExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>compExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompExp([NotNull] HaskellmmParser.CompExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parenExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenExp([NotNull] HaskellmmParser.ParenExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenExp([NotNull] HaskellmmParser.ParenExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>addExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddExp([NotNull] HaskellmmParser.AddExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddExp([NotNull] HaskellmmParser.AddExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>refExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRefExp([NotNull] HaskellmmParser.RefExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>refExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRefExp([NotNull] HaskellmmParser.RefExpContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>iteExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIteExp([NotNull] HaskellmmParser.IteExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>iteExp</c>
	/// labeled alternative in <see cref="HaskellmmParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIteExp([NotNull] HaskellmmParser.IteExpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="HaskellmmParser.f_defi"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterF_defi([NotNull] HaskellmmParser.F_defiContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HaskellmmParser.f_defi"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitF_defi([NotNull] HaskellmmParser.F_defiContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="HaskellmmParser.ite_defi"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIte_defi([NotNull] HaskellmmParser.Ite_defiContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HaskellmmParser.ite_defi"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIte_defi([NotNull] HaskellmmParser.Ite_defiContext context);
}
