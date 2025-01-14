//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Italian\Italian-Numbers.yaml
//     - Language: Italian
//     - ClassName: NumbersDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.Italian
{
    using System;
    using System.Collections.Generic;

    public static class NumbersDefinitions
    {
      public const string LangMarker = @"Ita";
      public const bool CompoundNumberLanguage = true;
      public const bool MultiDecimalSeparatorCulture = false;
      public const string DigitsNumberRegex = @"\d|\d{1,3}(\.\d{3})";
      public const string RoundNumberIntegerRegex = @"(cent(o|(?!\b)|(?='))|mill(e|(?!\b)|(?='))|mila|miliard([oi]|(?!\b)|(?='))|(milion|bilion|trilion)([ei]|(?!\b)|(?=')))";
      public const string ZeroToNineIntegerRegex = @"(un[oa]?|due|tre|quattro|cinque|sei|sette|otto|nove|zero)";
      public const string TwoToNineIntegerRegex = @"(due|tre|quattro|cinque|sei|sette|otto|nove)";
      public const string NegativeNumberTermsRegex = @"(?<negTerm>meno\s+)";
      public static readonly string NegativeNumberSignRegex = $@"^{NegativeNumberTermsRegex}.*";
      public const string AnIntRegex = @"(un)(?=\s)";
      public const string TenToNineteenIntegerRegex = @"(diciott(o|(?!\b)|(?='))|(diciassett|diciannov)(e|(?!\b)|(?='))|(tredic|quattordic|quindic|sedic|undic|dodic|diec)(i|(?!\b)|(?=')))";
      public const string TensNumberIntegerRegex = @"(vent(i|(?!\b)|(?='))|(settant|trent|ottant|novant|quarant|cinquant|sessant)(a|(?!\b)|(?=')))";
      public static readonly string SeparaIntRegex = $@"((({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}{ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex})(\s*{RoundNumberIntegerRegex})*))|((({AnIntRegex})?(\s*{RoundNumberIntegerRegex})+))";
      public static readonly string AllIntRegex = $@"(((({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}{ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|({AnIntRegex})?)(\s*{RoundNumberIntegerRegex})+)\s*(e\s+)?)*{SeparaIntRegex})";
      public const string PlaceHolderPureNumber = @"\b";
      public const string PlaceHolderDefault = @"\D|\b";
      public static readonly Func<string, string> NumbersWithPlaceHolder = (placeholder) => $@"(((?<=\W|^)-\s*)|(?<=\b))\d+(?!(,\d+[a-zA-Z]))(?={placeholder})";
      public static readonly string NumbersWithSuffix = $@"(((?<=\W|^)-\s*)|(?<=\b))\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
      public static readonly string RoundNumberIntegerRegexWithLocks = $@"(?<=\b)({DigitsNumberRegex})+\s+{RoundNumberIntegerRegex}(?=\b)";
      public const string NumbersWithDozenSuffix = @"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s+dozzin[ae](?=\b)";
      public static readonly string AllIntRegexWithLocks = $@"((?<=\b){AllIntRegex}(?=\b))";
      public static readonly string AllIntRegexWithDozenSuffixLocks = $@"(?<=\b)(((mezza|una)\s+dozzina)|({AllIntRegex}\s+dozzin[ae]))(?=\b)";
      public const string RoundNumberOrdinalRegex = @"(centesim[oaie]|millesim[oaie]|milionesim[oaie]|miliardesim[oaie]|bilionesim[oaie]|trilionesim[oaie])";
      public const string OneToNineOrdinalRegex = @"(prim[oaie]|second[oaie]|terz[oaie]|quart[oaie]|quint[oaie]|sest[oaie]|settim[oaie]|ottav[oaie]|non[oaie])";
      public const string NumberOrdinalRegex = @"(prim[oaie]|second[oaie]|terz[oaie]|quart[oaie]|quint[oaie]|sest[oaie]|settim[oaie]|ottav[oaie]|non[oaie]|decim[oaie]|undicesim[oaie]|dodicesim[oaie]|tredicesim[oaie]|quattordicesim[oaie]|quindicesim[oaie]|sedicesim[oaie]|diciassettesim[oaie]|diciottesim[oaie]|diciannovesim[oaie]|ventesim[oaie]|trentesim[oaie]|quarantesim[oaie]|cinquantesim[oaie]|sessantesim[oaie]|settantesim[oaie]|ottantesim[oaie]|novantesim[oaie])";
      public const string OneToNineOrdinalCompoundRegex = @"(un|du|tre|quattr|cinqu|sei|sett|ott|nov)esim[oaie]";
      public const string RelativeOrdinalRegex = @"(precedente|seguente|penultim[oa]|terzultim[oa]|ultim[oa])";
      public static readonly string BasicOrdinalRegex = $@"(({NumberOrdinalRegex}|{RelativeOrdinalRegex})(?!\s*({TwoToNineIntegerRegex}|([2-9]+))\b))";
      public static readonly string SuffixBasicOrdinalRegex = $@"((((({TensNumberIntegerRegex}{ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|({AnIntRegex})|{RoundNumberIntegerRegex})(\s*{RoundNumberIntegerRegex})*)\s*(e\s+)?)*({TensNumberIntegerRegex}?{OneToNineOrdinalCompoundRegex}|{BasicOrdinalRegex}))";
      public static readonly string SuffixRoundNumberOrdinalRegex = $@"(({AllIntRegex}\s*)?{RoundNumberOrdinalRegex})";
      public static readonly string AllOrdinalRegex = $@"({SuffixRoundNumberOrdinalRegex}|{SuffixBasicOrdinalRegex})";
      public const string OrdinalSuffixRegex = @"(?<=\b)(\d+(°|(esi)?m[oaie]))";
      public const string OrdinalNumericRegex = @"(?<=\b)(\d{1,3}(\s*,\s*\d{3})*(°|(esi)?m[oaie]))";
      public static readonly string OrdinalRoundNumberRegex = $@"(?<!(un)\s+){RoundNumberOrdinalRegex}";
      public static readonly string OrdinalItalianRegex = $@"(?<=\b){AllOrdinalRegex}(?=\b)";
      public const string FractionNotationWithSpacesRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+(e\s+)?\d+[/]\d+(?=(\b[^/]|$))";
      public static readonly string FractionNotationRegex = $@"{BaseNumbers.FractionNotationRegex}";
      public static readonly string FractionMultiplierRegex = $@"(?<fracMultiplier>\s+e\s+(mezzo|(un|{TwoToNineIntegerRegex})\s+(mezz[oi]|quart[oi]|terz[oi]|quint[oi]|sest[oi]|settim[oi]|ottav[oi]|non[oi]|decim[oi])))";
      public static readonly string RoundMultiplierWithFraction = $@"(?<multiplier>(?:milion[ei]|miliard[oi]|bilion[ei]|trillion[ei]))(?={FractionMultiplierRegex}?$)";
      public static readonly string RoundMultiplierRegex = $@"\b\s*({RoundMultiplierWithFraction}|(?<multiplier>(cento|mille|mila))$)";
      public static readonly string FractionNounRegex = $@"(?<=\b)({AllIntRegex}\s+(e\s+)?)?(({AllIntRegex})(\s+|\s*-\s*)(?!\bprimo\b|\bsecondo\b)(mezzi|({AllOrdinalRegex})|({RoundNumberOrdinalRegex}))|(mezzo|un\s+quarto\s+di)\s+{RoundNumberIntegerRegex})(?=\b)";
      public static readonly string FractionNounWithArticleRegex = $@"(?<=\b)((({AllIntRegex}|{RoundNumberIntegerRegexWithLocks})\s+(e\s+)?)?((un)(\s+|\s*-\s*)(?!\bprimo\b|\bsecondo\b)({AllOrdinalRegex}|{RoundNumberOrdinalRegex})|(un\s+)?mezzo))(?=\b)";
      public static readonly string FractionPrepositionRegex = $@"(?<!{BaseNumbers.CommonCurrencySymbol}\s*)(?<=\b)(?<numerator>({AllIntRegex})|((?<!\.)\d+))\s+su\s+(?<denominator>({AllIntRegex})|(\d+)(?!\.))(?=\b)";
      public static readonly string AllPointRegex = $@"((\s+{ZeroToNineIntegerRegex})+|(\s+{SeparaIntRegex}))";
      public static readonly string AllFloatRegex = $@"({AllIntRegex}(\s+(virgola|punto)){AllPointRegex})";
      public static readonly Func<string, string> DoubleDecimalPointRegex = (placeholder) => $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))\d+,\d+(?!(,\d+))(?={placeholder})";
      public static readonly Func<string, string> DoubleWithoutIntegralRegex = (placeholder) => $@"(?<=\s|^)(?<!(\d+)),\d+(?!(,\d+))(?={placeholder})";
      public static readonly string DoubleWithMultiplierRegex = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\,)))\d+,\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
      public static readonly string DoubleWithRoundNumber = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\,)))\d+,\d+\s+{RoundNumberIntegerRegex}(?=\b)";
      public static readonly string DoubleAllFloatRegex = $@"((?<=\b){AllFloatRegex}(?=\b))";
      public const string ConnectorRegex = @"(?<spacer>e)";
      public const string DoubleExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))(\d+(,\d+)?)e([+-]*[1-9]\d*)(?=\b)";
      public const string DoubleCaretExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))(\d+(,\d+)?)\^([+-]*[1-9]\d*)(?=\b)";
      public static readonly string NumberWithSuffixPercentage = $@"(?<!%)({BaseNumbers.NumberReplaceToken})(\s*)(%(?!{BaseNumbers.NumberReplaceToken})|(per cento|percentuale|percento)\b)";
      public static readonly string NumberWithPrefixPercentage = $@"(per cento di|percento di)(\s*)({BaseNumbers.NumberReplaceToken})";
      public const string TillRegex = @"(a|fino\s+a|--|-|—|——|~|–)";
      public const string MoreRegex = @"((più\s+grand[ei]|più\s+(in\s+)?alt[oi]|maggior[ei]|al\s+di\s+sopra|più)(\s+di)?|sopra(\s+i)?|superior[ei](\s+a)?|(?<!<|=)>)";
      public const string LessRegex = @"((meno|più\s+(in\s+)?bass[oi]|più\s+piccol[oi]|minor[ei]|al\s+di\s+sotto)(\s+di)?|sotto(\s+i)?|inferior[ei](\s+a)?|(?<!>|=)<)";
      public const string EqualRegex = @"(ugual[ei](\s+a)?|(?<!<|>)=)";
      public static readonly string MoreOrEqualPrefix = $@"((non\s+((è|sono)\s+)?{LessRegex})|(almeno))";
      public static readonly string MoreOrEqual = $@"(({MoreRegex}\s+(o)?\s+{EqualRegex})|({EqualRegex}\s+(o)?\s+{MoreRegex})|{MoreOrEqualPrefix}(\s+(o)?\s+{EqualRegex})?|({EqualRegex}\s+(o)?\s+)?{MoreOrEqualPrefix}|>\s*=)";
      public const string MoreOrEqualSuffix = @"((e|o)\s+(((più\s+grand[ei]|più\s+(in\s+)?alt[oi]|maggior[ei]|al\s+di\s+sopra|più)((?!\s+di)|(\s+di(?!(\s*\d+)))))|((superior[ei])((?!\s+a)|(\s+a(?!(\s*\d+)))))))";
      public static readonly string LessOrEqualPrefix = $@"((non\s+((è|sono)\s+)?{MoreRegex})|(al\s+più))";
      public static readonly string LessOrEqual = $@"(({LessRegex}\s+(o)?\s+{EqualRegex})|({EqualRegex}\s+(o)?\s+{LessRegex})|{LessOrEqualPrefix}(\s+(o)?\s+{EqualRegex})?|({EqualRegex}\s+(o)?\s+)?{LessOrEqualPrefix}|<\s*=)";
      public const string LessOrEqualSuffix = @"((e|o)\s+(((meno|più\s+(in\s+)?bass[oi]|più\s+piccol[oi]|minor[ei]|al\s+di\s+sotto)((?!\s+di)|(\s+di(?!(\s*\d+)))))|((meno|inferior[ei])((?!\s+a)|(\s+a(?!(\s*\d+)))))))";
      public const string NumberSplitMark = @"(?![,.](?!\d+))";
      public const string MoreRegexNoNumberSucceed = @"((più\s+grand[ei]|più\s+(in\s+)?alt[oi]|maggior[ei]|al\s+di\s+sopra|più)((?!\s+di)|\s+(di(?!(\s*\d+))))|(sopra(\s+i)?|superior[ei](\s+a)?)(?!(\s*\d+)))";
      public const string LessRegexNoNumberSucceed = @"((meno|più\s+(in\s+)?bass[oi]|più\s+piccol[oi]|minor[ei]|al\s+di\s+sotto)((?!\s+di)|\s+(di(?!(\s*\d+))))|(sotto(\s+i)?|inferior[ei](\s+a)?)(?!(\s*\d+)))";
      public const string EqualRegexNoNumberSucceed = @"(ugual[ei]((?!\s+a)|(\s+a(?!(\s*\d+)))))";
      public static readonly string OneNumberRangeMoreRegex1 = $@"({MoreOrEqual}|{MoreRegex})\s*((il?|de[li])\s+)?(?<number1>({NumberSplitMark}.)+)";
      public static readonly string OneNumberRangeMoreRegex2 = $@"(?<number1>({NumberSplitMark}.)+)\s*{MoreOrEqualSuffix}";
      public static readonly string OneNumberRangeMoreSeparateRegex = $@"({EqualRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+or\s+){MoreRegexNoNumberSucceed})|({MoreRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+or\s+){EqualRegexNoNumberSucceed})";
      public static readonly string OneNumberRangeLessRegex1 = $@"({LessOrEqual}|{LessRegex})\s*((il?|de[li])\s+)?(?<number2>({NumberSplitMark}.)+)";
      public static readonly string OneNumberRangeLessRegex2 = $@"(?<number2>({NumberSplitMark}.)+)\s*{LessOrEqualSuffix}";
      public static readonly string OneNumberRangeLessSeparateRegex = $@"({EqualRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+o\s+){LessRegexNoNumberSucceed})|({LessRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+o\s+){EqualRegexNoNumberSucceed})";
      public static readonly string OneNumberRangeEqualRegex = $@"{EqualRegex}\s*((il?|de[li])\s+)?(?<number1>({NumberSplitMark}.)+)";
      public static readonly string TwoNumberRangeRegex1 = $@"(compres[oi]\s+)?[tf]ra\s*(il?\s+)?(?<number1>({NumberSplitMark}.)+)\s*e\s*(il?\s+)?(?<number2>({NumberSplitMark}.)+)";
      public static readonly string TwoNumberRangeRegex2 = $@"({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})\s*(e|(,\s+)?ma|,)\s*({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})";
      public static readonly string TwoNumberRangeRegex3 = $@"({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})\s*(e|(,\s+)?ma|,)\s*({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})";
      public static readonly string TwoNumberRangeRegex4 = $@"(da[li]?\s+)?(?<number1>({NumberSplitMark}(?!\bda\b).)+)\s*{TillRegex}\s*([li]\s+)?(?<number2>({NumberSplitMark}.)+)";
      public const char DecimalSeparatorChar = ',';
      public const string FractionMarkerToken = @"su";
      public const char NonDecimalSeparatorChar = '.';
      public const string HalfADozenText = @"sei";
      public const string WordSeparatorToken = @"e";
      public static readonly string[] WrittenDecimalSeparatorTexts = { @"virgola", @"punto" };
      public static readonly string[] WrittenGroupSeparatorTexts = { @"punto" };
      public static readonly string[] WrittenIntegerSeparatorTexts = { @"e", @"-" };
      public static readonly string[] WrittenFractionSeparatorTexts = { @"e" };
      public static readonly string[] OneHalfTokens = { @"un", @"mezzo" };
      public const string HalfADozenRegex = @"mezza\s+dozzina";
      public static readonly string DigitalNumberRegex = $@"((?<=\b)(cento|mille|milione|milioni|miliardo|miliardi|bilione|bilioni|trilione|trilioni|dozzina|dozzine)(?=\b))|((?<=(\d|\b)){BaseNumbers.MultiplierLookupRegex}(?=\b))";
      public const string AmbiguousFractionConnectorsRegex = @"(\bnel\b)";
      public static readonly Dictionary<string, long> CardinalNumberMap = new Dictionary<string, long>
        {
            { @"zero", 0 },
            { @"un", 1 },
            { @"una", 1 },
            { @"uno", 1 },
            { @"due", 2 },
            { @"tre", 3 },
            { @"quattro", 4 },
            { @"cinque", 5 },
            { @"sei", 6 },
            { @"sette", 7 },
            { @"otto", 8 },
            { @"tto", 8 },
            { @"nove", 9 },
            { @"dieci", 10 },
            { @"undici", 11 },
            { @"dodici", 12 },
            { @"dozzina", 12 },
            { @"dozzine", 12 },
            { @"tredici", 13 },
            { @"quattordici", 14 },
            { @"quindici", 15 },
            { @"sedici", 16 },
            { @"diciassette", 17 },
            { @"diciotto", 18 },
            { @"diciannove", 19 },
            { @"venti", 20 },
            { @"vent", 20 },
            { @"trenta", 30 },
            { @"trent", 30 },
            { @"quaranta", 40 },
            { @"quarant", 40 },
            { @"cinquanta", 50 },
            { @"cinquant", 50 },
            { @"sessanta", 60 },
            { @"sessant", 60 },
            { @"settanta", 70 },
            { @"settant", 70 },
            { @"ottanta", 80 },
            { @"ottant", 80 },
            { @"ttanta", 80 },
            { @"ttant", 80 },
            { @"novanta", 90 },
            { @"novant", 90 },
            { @"cento", 100 },
            { @"cent", 100 },
            { @"mille", 1000 },
            { @"mila", 1000 },
            { @"milione", 1000000 },
            { @"milioni", 1000000 },
            { @"miliardo", 1000000000 },
            { @"miliardi", 1000000000 },
            { @"bilione", 1000000000000 },
            { @"bilioni", 1000000000000 },
            { @"trilione", 1000000000000000000 },
            { @"trilioni", 1000000000000000000 }
        };
      public static readonly Dictionary<string, long> OrdinalNumberMap = new Dictionary<string, long>
        {
            { @"primo", 1 },
            { @"prima", 1 },
            { @"secondo", 2 },
            { @"seconda", 2 },
            { @"metà", 2 },
            { @"mezzo", 2 },
            { @"mezza", 2 },
            { @"terzo", 3 },
            { @"terza", 3 },
            { @"quarto", 4 },
            { @"quarta", 4 },
            { @"quinto", 5 },
            { @"quinta", 5 },
            { @"sesto", 6 },
            { @"sesta", 6 },
            { @"settimo", 7 },
            { @"settima", 7 },
            { @"ottavo", 8 },
            { @"ottava", 8 },
            { @"ttavo", 8 },
            { @"ttava", 8 },
            { @"nono", 9 },
            { @"nona", 9 },
            { @"decimo", 10 },
            { @"decima", 10 },
            { @"undicesimo", 11 },
            { @"undicesima", 11 },
            { @"dodicesimo", 12 },
            { @"dodicesima", 12 },
            { @"tredicesimo", 13 },
            { @"tredicesima", 13 },
            { @"quattordicesimo", 14 },
            { @"quattordicesima", 14 },
            { @"quindicesimo", 15 },
            { @"quindicesima", 15 },
            { @"sedicesimo", 16 },
            { @"sedicesima", 16 },
            { @"diciassettesimo", 17 },
            { @"diciassettesima", 17 },
            { @"diciottesimo", 18 },
            { @"diciottesima", 18 },
            { @"diciannovesimo", 19 },
            { @"diciannovesima", 19 },
            { @"ventesimo", 20 },
            { @"ventesima", 20 },
            { @"ventunesimo", 21 },
            { @"ventunesima", 21 },
            { @"trentesimo", 30 },
            { @"trentesima", 30 },
            { @"quarantesimo", 40 },
            { @"quarantesima", 40 },
            { @"cinquantesimo", 50 },
            { @"cinquantesima", 50 },
            { @"sessantesimo", 60 },
            { @"sessantesima", 60 },
            { @"settantesimo", 70 },
            { @"settantesima", 70 },
            { @"ottantesimo", 80 },
            { @"ottantesima", 80 },
            { @"ttantesimo", 80 },
            { @"ttantesima", 80 },
            { @"novantesimo", 90 },
            { @"novantesima", 90 },
            { @"centesimo", 100 },
            { @"centesima", 100 },
            { @"millesimo", 1000 },
            { @"millesima", 1000 },
            { @"milionesimo", 1000000 },
            { @"milionesima", 1000000 },
            { @"miliardesimo", 1000000000 },
            { @"miliardesima", 1000000000 },
            { @"bilionesimo", 1000000000000 },
            { @"bilionesima", 1000000000000 },
            { @"trilionesimo", 1000000000000000000 },
            { @"trilionesima", 1000000000000000000 },
            { @"primi", 1 },
            { @"prime", 1 },
            { @"secondi", 2 },
            { @"seconde", 2 },
            { @"mezzi", 2 },
            { @"mezze", 2 },
            { @"terzi", 3 },
            { @"terze", 3 },
            { @"quarti", 4 },
            { @"quarte", 4 },
            { @"quinti", 5 },
            { @"quinte", 5 },
            { @"sesti", 6 },
            { @"seste", 6 },
            { @"settimi", 7 },
            { @"settime", 7 },
            { @"ottavi", 8 },
            { @"ottave", 8 },
            { @"noni", 9 },
            { @"none", 9 },
            { @"unesimo", 1 },
            { @"unesima", 1 },
            { @"unesime", 1 },
            { @"unesimi", 1 },
            { @"duesimo", 2 },
            { @"duesima", 2 },
            { @"duesime", 2 },
            { @"duesimi", 2 },
            { @"treesimo", 3 },
            { @"treesima", 3 },
            { @"treesime", 3 },
            { @"treesimi", 3 },
            { @"quattresimo", 4 },
            { @"quattresima", 4 },
            { @"quattresime", 4 },
            { @"quattresimi", 4 },
            { @"cinquesimo", 5 },
            { @"cinquesima", 5 },
            { @"cinquesime", 5 },
            { @"cinquesimi", 5 },
            { @"seiesimo", 6 },
            { @"seiesima", 6 },
            { @"seiesime", 6 },
            { @"seiesimi", 6 },
            { @"settesimo", 7 },
            { @"settesima", 7 },
            { @"settesime", 7 },
            { @"settesimi", 7 },
            { @"ottesimo", 8 },
            { @"ottesima", 8 },
            { @"ottesime", 8 },
            { @"ottesimi", 8 },
            { @"novesimo", 9 },
            { @"novesima", 9 },
            { @"novesime", 9 },
            { @"novesimi", 9 },
            { @"decimi", 10 },
            { @"decime", 10 },
            { @"undicesimi", 11 },
            { @"undicesime", 11 },
            { @"dodicesimi", 12 },
            { @"dodicesime", 12 },
            { @"tredicesimi", 13 },
            { @"tredicesime", 13 },
            { @"quattordicesimi", 14 },
            { @"quattordicesime", 14 },
            { @"quindicesimi", 15 },
            { @"quindicesime", 15 },
            { @"sedicesimi", 16 },
            { @"sedicesime", 16 },
            { @"diciassettesimi", 17 },
            { @"diciassettesime", 17 },
            { @"diciottesimi", 18 },
            { @"diciottesime", 18 },
            { @"diciannovesimi", 19 },
            { @"diciannovesime", 19 },
            { @"ventesimi", 20 },
            { @"ventesime", 20 },
            { @"trentesimi", 30 },
            { @"trentesime", 30 },
            { @"quarantesimi", 40 },
            { @"quarantesime", 40 },
            { @"cinquantesimi", 50 },
            { @"cinquantesime", 50 },
            { @"sessantesimi", 60 },
            { @"sessantesime", 60 },
            { @"settantesimi", 70 },
            { @"settantesime", 70 },
            { @"ottantesimi", 80 },
            { @"ottantesime", 80 },
            { @"ttantesimi", 80 },
            { @"ttantesime", 80 },
            { @"novantesimi", 90 },
            { @"novantesime", 90 },
            { @"centesimi", 100 },
            { @"centesime", 100 },
            { @"millesimi", 1000 },
            { @"millesime", 1000 },
            { @"milionesimi", 1000000 },
            { @"milionesime", 1000000 },
            { @"miliardesimi", 1000000000 },
            { @"miliardesime", 1000000000 },
            { @"bilionesimi", 1000000000000 },
            { @"bilionesime", 1000000000000 },
            { @"trilionesimi", 1000000000000000000 },
            { @"trilionesime", 1000000000000000000 }
        };
      public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
        {
            { @"cento", 100 },
            { @"mille", 1000 },
            { @"mila", 1000 },
            { @"milione", 1000000 },
            { @"milioni", 1000000 },
            { @"miliardo", 1000000000 },
            { @"miliardi", 1000000000 },
            { @"bilione", 1000000000000 },
            { @"bilioni", 1000000000000 },
            { @"trilione", 1000000000000000000 },
            { @"trilioni", 1000000000000000000 },
            { @"centinaio", 100 },
            { @"centinai", 100 },
            { @"centinaie", 100 },
            { @"millesimo", 1000 },
            { @"milionesimo", 1000000 },
            { @"miliardesimo", 1000000000 },
            { @"bilionesimo", 1000000000000 },
            { @"trilionesimo", 1000000000000000000 },
            { @"millesima", 1000 },
            { @"milionesima", 1000000 },
            { @"miliardesima", 1000000000 },
            { @"bilionesima", 1000000000000 },
            { @"trilionesima", 1000000000000000000 },
            { @"millesimi", 1000 },
            { @"milionesimi", 1000000 },
            { @"miliardesimi", 1000000000 },
            { @"bilionesimi", 1000000000000 },
            { @"trilionesimi", 1000000000000000000 },
            { @"millesime", 1000 },
            { @"milionesime", 1000000 },
            { @"miliardesime", 1000000000 },
            { @"bilionesime", 1000000000000 },
            { @"trilionesime", 1000000000000000000 },
            { @"centinaia", 100 },
            { @"migliaia", 1000 },
            { @"milionata", 1000000 },
            { @"miliardata", 1000000000 },
            { @"bilionata", 1000000000000 },
            { @"trilionata", 1000000000000000000 },
            { @"dozzina", 12 },
            { @"dozzine", 12 },
            { @"k", 1000 },
            { @"m", 1000000 },
            { @"g", 1000000000 },
            { @"b", 1000000000 },
            { @"t", 1000000000000 }
        };
      public static readonly Dictionary<string, string> AmbiguityFiltersDict = new Dictionary<string, string>
        {
            { @"^[.]", @"" }
        };
      public static readonly Dictionary<string, string> RelativeReferenceOffsetMap = new Dictionary<string, string>
        {
            { @"ultimo", @"0" },
            { @"ultima", @"0" },
            { @"ultimi", @"0" },
            { @"ultime", @"0" },
            { @"successivo", @"1" },
            { @"successiva", @"1" },
            { @"successivi", @"1" },
            { @"successive", @"1" },
            { @"prossimo", @"1" },
            { @"prossima", @"1" },
            { @"prossimi", @"1" },
            { @"prossime", @"1" },
            { @"seguente", @"1" },
            { @"seguenti", @"1" },
            { @"precedente", @"-1" },
            { @"precedenti", @"-1" },
            { @"penultimo", @"-1" },
            { @"penultima", @"-1" },
            { @"penultimi", @"-1" },
            { @"penultime", @"-1" },
            { @"terz'ultimo", @"-2" },
            { @"terz'ultima", @"-2" },
            { @"terz'ultimi", @"-2" },
            { @"terz'ultime", @"-2" },
            { @"terzultimo", @"-2" },
            { @"terzultima", @"-2" },
            { @"terzultimi", @"-2" },
            { @"terzultime", @"-2" },
            { @"quart'ultimo", @"-3" },
            { @"quart'ultima", @"-3" },
            { @"quart'ultimi", @"-3" },
            { @"quart'ultime", @"-3" },
            { @"quartultimo", @"-3" },
            { @"quartultima", @"-3" },
            { @"quartultimi", @"-3" },
            { @"quartultime", @"-3" }
        };
      public static readonly Dictionary<string, string> RelativeReferenceRelativeToMap = new Dictionary<string, string>
        {
            { @"ultimo", @"end" },
            { @"ultima", @"end" },
            { @"ultimi", @"end" },
            { @"ultime", @"end" },
            { @"successivo", @"current" },
            { @"successiva", @"current" },
            { @"successivi", @"current" },
            { @"successive", @"current" },
            { @"prossimo", @"current" },
            { @"prossima", @"current" },
            { @"prossimi", @"current" },
            { @"prossime", @"current" },
            { @"seguente", @"current" },
            { @"seguenti", @"current" },
            { @"precedente", @"current" },
            { @"precedenti", @"current" },
            { @"penultimo", @"end" },
            { @"penultima", @"end" },
            { @"penultimi", @"end" },
            { @"penultime", @"end" },
            { @"terz'ultimo", @"end" },
            { @"terz'ultima", @"end" },
            { @"terz'ultimi", @"end" },
            { @"terz'ultime", @"end" },
            { @"terzultimo", @"end" },
            { @"terzultima", @"end" },
            { @"terzultimi", @"end" },
            { @"terzultime", @"end" },
            { @"quart'ultimo", @"end" },
            { @"quart'ultima", @"end" },
            { @"quart'ultimi", @"end" },
            { @"quart'ultime", @"end" },
            { @"quartultimo", @"end" },
            { @"quartultima", @"end" },
            { @"quartultimi", @"end" },
            { @"quartultime", @"end" }
        };
    }
}