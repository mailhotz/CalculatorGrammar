//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\Calculator.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class CalculatorLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		OPERATOR=1, NUMBERS=2, WS=3;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"OPERATOR", "NUMBERS", "WS"
	};


	public CalculatorLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CalculatorLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
	};
	private static readonly string[] _SymbolicNames = {
		null, "OPERATOR", "NUMBERS", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Calculator.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static CalculatorLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x5', '\x17', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x6', '\x3', '\r', '\n', '\x3', '\r', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\x4', '\x6', '\x4', '\x12', '\n', '\x4', '\r', '\x4', 
		'\xE', '\x4', '\x13', '\x3', '\x4', '\x3', '\x4', '\x2', '\x2', '\x5', 
		'\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\x3', '\x2', '\x5', '\x5', '\x2', 
		',', '-', '/', '/', '\x31', '\x31', '\x3', '\x2', '\x32', ';', '\x5', 
		'\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\x18', '\x2', '\x3', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x3', '\t', '\x3', '\x2', '\x2', 
		'\x2', '\x5', '\f', '\x3', '\x2', '\x2', '\x2', '\a', '\x11', '\x3', '\x2', 
		'\x2', '\x2', '\t', '\n', '\t', '\x2', '\x2', '\x2', '\n', '\x4', '\x3', 
		'\x2', '\x2', '\x2', '\v', '\r', '\t', '\x3', '\x2', '\x2', '\f', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\r', '\xE', '\x3', '\x2', '\x2', '\x2', '\xE', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\xE', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\xF', '\x6', '\x3', '\x2', '\x2', '\x2', '\x10', '\x12', '\t', '\x4', 
		'\x2', '\x2', '\x11', '\x10', '\x3', '\x2', '\x2', '\x2', '\x12', '\x13', 
		'\x3', '\x2', '\x2', '\x2', '\x13', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\x13', '\x14', '\x3', '\x2', '\x2', '\x2', '\x14', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\x15', '\x16', '\b', '\x4', '\x2', '\x2', '\x16', '\b', 
		'\x3', '\x2', '\x2', '\x2', '\x5', '\x2', '\xE', '\x13', '\x3', '\b', 
		'\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
