﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralKata
{
    public class RomanNumeral
    {
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

            string romanNumeral = null;
            if (_arabicToRomanLookup.TryGetValue(arabicNumber, out romanNumeral))
                return romanNumeral;

            return null;
        }
    }
}
