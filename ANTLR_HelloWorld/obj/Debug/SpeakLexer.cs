//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\0MyDesktop\ANTLR_HelloWorld\ANTLR_HelloWorld\Speak.g4 by ANTLR 4.6.6-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ANTLR_HelloWorld {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class SpeakLexer : Lexer {
	public const int
		SAYS=1, WORD=2, TEXT=3, WHITESPACE=4, NEWLINE=5;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"A", "S", "Y", "LOWERCASE", "UPPERCASE", "SAYS", "WORD", "TEXT", "WHITESPACE", 
		"NEWLINE"
	};


	public SpeakLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
	};
	private static readonly string[] _SymbolicNames = {
		null, "SAYS", "WORD", "TEXT", "WHITESPACE", "NEWLINE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Speak.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\a\x45\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3"+
		"\x5\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x6\b)\n\b\r\b\xE\b"+
		"*\x3\t\x3\t\a\t/\n\t\f\t\xE\t\x32\v\t\x3\t\x3\t\x3\n\x6\n\x37\n\n\r\n"+
		"\xE\n\x38\x3\n\x3\n\x3\v\x5\v>\n\v\x3\v\x3\v\x6\v\x42\n\v\r\v\xE\v\x43"+
		"\x3\x30\x2\x2\f\x3\x2\x2\x5\x2\x2\a\x2\x2\t\x2\x2\v\x2\x2\r\x2\x3\xF\x2"+
		"\x4\x11\x2\x5\x13\x2\x6\x15\x2\a\x3\x2\b\x4\x2\x43\x43\x63\x63\x4\x2U"+
		"Uuu\x4\x2[[{{\x3\x2\x63|\x3\x2\x43\\\x4\x2\v\v\"\"\x46\x2\r\x3\x2\x2\x2"+
		"\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2"+
		"\x2\x2\x3\x17\x3\x2\x2\x2\x5\x19\x3\x2\x2\x2\a\x1B\x3\x2\x2\x2\t\x1D\x3"+
		"\x2\x2\x2\v\x1F\x3\x2\x2\x2\r!\x3\x2\x2\x2\xF(\x3\x2\x2\x2\x11,\x3\x2"+
		"\x2\x2\x13\x36\x3\x2\x2\x2\x15\x41\x3\x2\x2\x2\x17\x18\t\x2\x2\x2\x18"+
		"\x4\x3\x2\x2\x2\x19\x1A\t\x3\x2\x2\x1A\x6\x3\x2\x2\x2\x1B\x1C\t\x4\x2"+
		"\x2\x1C\b\x3\x2\x2\x2\x1D\x1E\t\x5\x2\x2\x1E\n\x3\x2\x2\x2\x1F \t\x6\x2"+
		"\x2 \f\x3\x2\x2\x2!\"\x5\x5\x3\x2\"#\x5\x3\x2\x2#$\x5\a\x4\x2$%\x5\x5"+
		"\x3\x2%\xE\x3\x2\x2\x2&)\x5\t\x5\x2\')\x5\v\x6\x2(&\x3\x2\x2\x2(\'\x3"+
		"\x2\x2\x2)*\x3\x2\x2\x2*(\x3\x2\x2\x2*+\x3\x2\x2\x2+\x10\x3\x2\x2\x2,"+
		"\x30\a$\x2\x2-/\v\x2\x2\x2.-\x3\x2\x2\x2/\x32\x3\x2\x2\x2\x30\x31\x3\x2"+
		"\x2\x2\x30.\x3\x2\x2\x2\x31\x33\x3\x2\x2\x2\x32\x30\x3\x2\x2\x2\x33\x34"+
		"\a$\x2\x2\x34\x12\x3\x2\x2\x2\x35\x37\t\a\x2\x2\x36\x35\x3\x2\x2\x2\x37"+
		"\x38\x3\x2\x2\x2\x38\x36\x3\x2\x2\x2\x38\x39\x3\x2\x2\x2\x39:\x3\x2\x2"+
		"\x2:;\b\n\x2\x2;\x14\x3\x2\x2\x2<>\a\xF\x2\x2=<\x3\x2\x2\x2=>\x3\x2\x2"+
		"\x2>?\x3\x2\x2\x2?\x42\a\f\x2\x2@\x42\a\xF\x2\x2\x41=\x3\x2\x2\x2\x41"+
		"@\x3\x2\x2\x2\x42\x43\x3\x2\x2\x2\x43\x41\x3\x2\x2\x2\x43\x44\x3\x2\x2"+
		"\x2\x44\x16\x3\x2\x2\x2\n\x2(*\x30\x38=\x41\x43\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ANTLR_HelloWorld
