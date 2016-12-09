using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralKata;

namespace RomanNumeralKataTests
{
    [TestClass]
    public class RomanNumeralTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenConvertingToRomanNegativeNumbersThrowOutOfRange()
        {
            RomanNumeral roman = new RomanNumeral();
            roman.ToRoman(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenConvertingToRomanZeroThrowsOutOfRange()
        {
            RomanNumeral roman = new RomanNumeral();
            roman.ToRoman(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenConvertingToRomanGreaterThan4000ThrowsOutOfRange()
        {
            RomanNumeral roman = new RomanNumeral();
            roman.ToRoman(4321);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenConvertingToRoman4000ThrowsOutOfRange()
        {
            RomanNumeral roman = new RomanNumeral();
            roman.ToRoman(4000);
        }
    }
}
