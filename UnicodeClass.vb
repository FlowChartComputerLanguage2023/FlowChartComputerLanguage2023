

Namespace MyFlowChartNameSpace
    'TODO NEED TO ADD THESE 'special' characters to the /Grammar (overridable)
    'todo need to check that these are in one of the /Grammars ?
    'special predefined Grammar key words
    'FCCL_EndOfLine		0x000D	0x000A	0x2028	0x2029
    'FCCL_LessThan		<
    'FCCL_GreaterThan	>
    'FCCL_SQuote		0x0027	0x2018	0x2019
    'FCCL_WhiteSpace    Unicode.Zs  0x0009
    Public Class MyUnicode
        Public Shared Function TestUnicode(Letter As String, My_Class As String, U() As String) As String
            'F_C.Logif mydebug(9) then follow(2670, "Test Unicode, " & AscW(Letter).ToString & ",  " & My_Class & vbCrLf)
            For I = 0 To UBound(U)
                'F_C.Logif mydebug(9) then follow(2671, I.ToString & "<-->" & U(I) & "<--->" & Letter & "<---> " & My_Class)
                If F_C.TestUnicodeRange(U(I), Letter) = True Then
                    Return My_Class
                End If
            Next
            Return ""
        End Function





        Public Shared Function FindUnicodeClass(Letter As String) As String
            'Dim RTN As String
            Dim Category() = {"Lu", "Ll", "Lt", "Lm", "Lo", "Mn", "Mc", "Me", "Nd", "Nl", "No", "Zs", "Zl", "Zp", "Cc", "Cf", "Cs", "Co", "Pc", "Pd", "Ps", "Pe", "Pi", "Pf", "Po", "Sm", "Sc", "Sk", "So", "Cn", "Ws"}
            Dim RTN As Int32
            Static Ws() As String = {"0x0009-0x000D", "0x0020", "0x0085", "0x00A0", "0x1680", "0x180E", "0x2000-0x200D", "0x2028", "0x202F", "0x205F", "0x2060", "0x3000", "0xFEFF"}
            If TestUnicode(Letter, "Ws", Ws) <> "" Then
                F_C.Follow(2738, 10, "White Space character " & AscW(Letter) & "  0x" & F_C.Str2Hex(Letter))
                Return "Ws" 'whitespace
            End If
            RTN = Char.GetUnicodeCategory(Letter, 1)
            Return Category(RTN)
        End Function
    End Class
    ' Ws white space

    '00 Upper case Letter 	"Lu" (letter, upper case). 0.
    '01 Lower case Letter 	"Ll" (letter, lower case). 1.
    '02 Title case Letter 	"Lt" (letter, title case). 2.
    '03 ModifierLetter 	Modifier letter character, which Is free-standing spacing character that indicates modifications of a preceding letter. "Lm" (letter, modifier). 3.
    '04 OtherLetter 	Not an upper Case letter, a lower Case letter, a title Case letter, Or a modifier letter. "Lo" (letter, other). 4.
    '05 NonSpacingMark 	5 	NonSpacing character that indicates modifications of a base character. "Mn" (mark, non spacing). 5.
    '06 SpacingCombiningMark 	6 	Spacing character that indicates modifications of a base character And affects the width of the glyph for that base character. "Mc" (mark, spacing combining). 6.
    '07 EnclosingMark 	7 	Enclosing mark character, which Is a non spacing combining character that surrounds all previous characters up to And including a base character. "Me" (mark, enclosing). 7.
    '08 DecimalDigitNumber 	8 	Decimal digit character, that Is, a character representing an integer in the range 0 through 9. "Nd" (number, decimal digit). 8.
    '09 LetterNumber 	9 	Number represented by a letter, instead of a decimal digit, for example, the Roman numeral for five, which Is "V". The indicator Is "Nl" (number, letter). 9.
    '10 OtherNumber 	10 	Number that Is neither a decimal digit nor a letter number, for example, the fraction 1/2. The indicator Is "No" (number, other). 10.
    '11 SpaceSeparator 	11 	Space character, which has no glyph but Is Not a control Or format character. "Zs" (separator, space). 11.
    '12 LineSeparator 	12 	Character that Is used to separate lines of text. "Zl" (separator, line). 12.
    '13 ParagraphSeparator 	13 	Character used to separate paragraphs. "Zp" (separator, paragraph). 13.
    '14 Control 	14 	Control code character, with a Unicode value of U+007F Or in the range U+0000 through U+001F Or U+0080 through U+009F. "Cc" (other, control). 14.
    '15 Format 	15 	Format character that affects the layout of text Or the operation of text processes, but Is Not normally rendered. "Cf" (other, format). 15.
    '16 Surrogate 	16 	High surrogate Or a low surrogate character. Surrogate code values are in the range U+D800 through U+DFFF. "Cs" (other, surrogate). 16.
    '17 PrivateUse 	17 	Private-use character, with a Unicode value in the range U+E000 through U+F8FF. "Co" (other, private use). 17.
    '18 ConnectorPunctuation 	18 	Connector punctuation character that connects two characters. "Pc" (punctuation, connector). 18.
    '19 DashPunctuation 	19 	Dash Or hyphen character. "Pd" (punctuation, dash). 19.
    '20 OpenPunctuation 	20 	Opening character of one of the paired punctuation marks, such as parentheses, square brackets, And braces. "Ps" (punctuation, open). 20.
    '21 ClosePunctuation 	21 		Closing character of one of the paired punctuation marks, such as parentheses, square brackets, And braces. "Pe" (punctuation, close). 21.
    '22 InitialQuotePunctuation 	22 	Opening Or initial quotation mark character. "Pi" (punctuation, initial quote). 22.
    '23 FinalQuotePunctuation 	23 	Closing Or final quotation mark character. "Pf" (punctuation, final quote). 23.
    '24 OtherPunctuation 	24 	Punctuation character that Is Not a connector, a dash, open punctuation, close punctuation, an initial quote, Or a final quote. "Po" (punctuation, other). 24.
    '25 MathSymbol 	25 	Mathematical Symbol character, such as "+" Or "= ". "Sm" (Symbol, math). 25.
    '26 CurrencySymbol 	26 	Currency Symbol character. "Sc" (Symbol, currency). 26.
    '27 ModifierSymbol 	27 	Modifier Symbol character, which indicates modifications of surrounding characters. For example, the fraction slash indicates that the number to the left Is the numerator And the number to the right Is the denominator. The indicator Is signified by the   Unicode designation "Sk" (Symbol, modifier). 27.
    '28 OtherSymbol 	28 	Symbol character that Is Not a mathematical Symbol, a currency Symbol Or a modifier Symbol. "So" (Symbol, other). 28.
    '29 OtherNotAssigned 	29 	Character that Is Not assigned to any Unicode category. "Cn" (other, Not assigned). 29.
End Namespace

