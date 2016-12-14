using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralKata
{
    public class RomanNumeral
    {
        #region ToRoman

        private static readonly List<ArabicToRomanConversion> _arabicToRomanLookup = new List<ArabicToRomanConversion>()
        {
            new ArabicToRomanConversion(1, "I"),
            new ArabicToRomanConversion(4, "IV"),
            new ArabicToRomanConversion(5, "V"),
            new ArabicToRomanConversion(9, "IX"),
            new ArabicToRomanConversion(10, "X"),
            new ArabicToRomanConversion(40, "XL"),
            new ArabicToRomanConversion(50, "L"),
            new ArabicToRomanConversion(90, "XC"),
            new ArabicToRomanConversion(100, "C"),
            new ArabicToRomanConversion(400, "CD"),
            new ArabicToRomanConversion(500, "D"),
            new ArabicToRomanConversion(900, "CM"),
            new ArabicToRomanConversion(1000, "M")
        };

        public string ToRoman(int arabicNumber)
        {
            if (arabicNumber <= 0 || arabicNumber >= 4000)
            {
                throw new ArgumentOutOfRangeException(
                    "arabicNumber",
                    arabicNumber,
                    "An Arabic number must be between 1 and 3999 to be converted to Roman numerals.");
            }

            /*
             * Basic strategy here:
             * - go through the Arabic-to-Roman lookup in reverse order by value (1000 to 1).
             * - find out how many of that value exists in the Arabic value
             *      - if 0, move on
             *      - if > 0,
             *          - append that many of the appropriate Roman numeral to the output.
             *          - reduce the value to be converted by the amount you just converted to
             *              Roman (e.g., if it's 2001 and you just converted 2000 to MM, reduce
             *              the value to convert by 2000 -> 1)
             * - when done, return the Roman numeral string
             * 
             * This leads to (for example):
             *  1973
             *   973    M
             *    73    MCM
             *    23    MCML
             *     3    MCMLXX
             *     0    MCMLXXIII
             */
            StringBuilder romanNumeral = new StringBuilder();
            foreach (ArabicToRomanConversion conversion in _arabicToRomanLookup.OrderByDescending(arc => arc.Arabic))
            {
                int numValues = GetNumValues(arabicNumber, conversion.Arabic);
                if (numValues > 0)
                {
                    for (int i = 0; i < numValues; ++i)
                        romanNumeral.Append(conversion.Roman);
                    arabicNumber -= conversion.Arabic * numValues;
                }
            }

            return romanNumeral.ToString();
        }

        private int GetNumValues(int arabicNumber, int valueOfRomanNumeral)
        {
            return arabicNumber / valueOfRomanNumeral;
        }

        #endregion

        #region ToArabic

        public int ToArabic(string romanNumeral)
        {
            if (String.IsNullOrWhiteSpace(romanNumeral))
                return 0;

            romanNumeral = romanNumeral.Trim();
            ArabicToRomanConversion conversion = _arabicToRomanLookup.FirstOrDefault(arc => arc.Roman == romanNumeral);
            if (conversion != null)
                return conversion.Arabic;

            return -1;
        }

        #endregion
    }
}
