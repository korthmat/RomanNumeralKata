using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralKata
{
    public class RomanNumeral
    {
        #region ToRoman

        private static readonly Dictionary<int, string> _arabicToRomanLookup = new Dictionary<int, string>()
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M" }
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
            foreach (int value in _arabicToRomanLookup.Keys.OrderByDescending(v => v))
            {
                int numValues = arabicNumber / value;
                if (numValues > 0)
                {
                    for (int i = 0; i < numValues; ++i)
                        romanNumeral.Append(_arabicToRomanLookup[value]);
                    arabicNumber -= value * numValues;
                }
            }

            return romanNumeral.ToString();
        }

        #endregion

        #region ToArabic

        public int ToArabic(string romanNumeral)
        {
            if (String.IsNullOrWhiteSpace(romanNumeral))
                return 0;

            romanNumeral = romanNumeral.Trim();
            if (romanNumeral == "I")
                return 1;
            else if (romanNumeral == "V")
                return 5;

            return -1;
        }

        #endregion
    }
}
