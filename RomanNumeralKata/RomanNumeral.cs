using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralKata
{
    public class RomanNumeral
    {
        public string ToRoman(int arabicNumber)
        {
            if (arabicNumber <= 0)
                throw new ArgumentOutOfRangeException("arabicNumber", arabicNumber, "A zero or negative Arabic number cannot be converted to Roman numerals.");
            if (arabicNumber >= 4000)
                throw new ArgumentOutOfRangeException("arabicNumber", arabicNumber, "An Arabic number greater than or equal to 4000 cannot be converted to Roman numerals.");

            return null;
        }
    }
}
