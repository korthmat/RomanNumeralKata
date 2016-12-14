using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralKata
{
    public class RomanNumeral
    {
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

        #region ToRoman

        public string ToRoman(int arabicNumber)
        {
            if (arabicNumber <= 0 || arabicNumber >= 4000)
            {
                throw new ArgumentOutOfRangeException(
                    "arabicNumber",
                    arabicNumber,
                    "An Arabic number must be between 1 and 3999 to be converted to Roman numerals.");
            }

            StringBuilder romanNumeral = new StringBuilder();
            foreach (ArabicToRomanConversion conversion in _arabicToRomanLookup.OrderByDescending(arc => arc.Arabic))
            {
                int numNumeralsToAppend = GetNumNumeralsToAppend(arabicNumber, conversion.Arabic);
                AppendRomanNumeralsToOutput(romanNumeral, conversion.Roman, numNumeralsToAppend);
                arabicNumber = AdjustArabicNumberValue(arabicNumber, conversion.Arabic, numNumeralsToAppend);
            }

            return romanNumeral.ToString();
        }

        private int GetNumNumeralsToAppend(int arabicNumber, int valueOfRomanNumeral)
        {
            return arabicNumber / valueOfRomanNumeral;
        }

        private void AppendRomanNumeralsToOutput(
            StringBuilder outputRomanNumeral,
            string romanNumeralToAppend,
            int numNumeralsToAppend)
        {
            for (int i = 0; i < numNumeralsToAppend; ++i)
                outputRomanNumeral.Append(romanNumeralToAppend);
        }

        private int AdjustArabicNumberValue(int arabicNumber, int valueOfRomanNumeral, int numNumeralsToAppend)
        {
            arabicNumber -= valueOfRomanNumeral * numNumeralsToAppend;
            return arabicNumber;
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
