using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralKata;

namespace RomanNumeralKataTests
{
    [TestClass]
    public class RomanNumeralTest
    {
        private RomanNumeral _roman;

        public RomanNumeralTest()
        {
            _roman = new RomanNumeral();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenConvertingToRomanNegativeNumbersThrowOutOfRange()
        {
            _roman.ToRoman(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenConvertingToRomanZeroThrowsOutOfRange()
        {
            _roman.ToRoman(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenConvertingToRomanGreaterThan4000ThrowsOutOfRange()
        {
            _roman.ToRoman(4321);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenConvertingToRoman4000ThrowsOutOfRange()
        {
            _roman.ToRoman(4000);
        }

        [TestMethod]
        public void WhenConvertingToRoman1BecomesI()
        {
            Assert.AreEqual("I", _roman.ToRoman(1));
        }
    }
}
