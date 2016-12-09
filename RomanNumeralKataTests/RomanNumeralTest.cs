using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralKata;
using System;

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

        [TestMethod]
        public void WhenConvertingToRoman4BecomesIV()
        {
            Assert.AreEqual("IV", _roman.ToRoman(4));
        }

        [TestMethod]
        public void WhenConvertingToRoman5BecomesV()
        {
            Assert.AreEqual("V", _roman.ToRoman(5));
        }

        [TestMethod]
        public void WhenConvertingToRoman9BecomesIX()
        {
            Assert.AreEqual("IX", _roman.ToRoman(9));
        }

        [TestMethod]
        public void WhenConvertingToRoman10BecomesX()
        {
            Assert.AreEqual("X", _roman.ToRoman(10));
        }

        [TestMethod]
        public void WhenConvertingToRoman40BecomesXL()
        {
            Assert.AreEqual("XL", _roman.ToRoman(40));
        }

        [TestMethod]
        public void WhenConvertingToRoman50BecomesL()
        {
            Assert.AreEqual("L", _roman.ToRoman(50));
        }

        [TestMethod]
        public void WhenConvertingToRoman90BecomesXC()
        {
            Assert.AreEqual("XC", _roman.ToRoman(90));
        }

        [TestMethod]
        public void WhenConvertingToRoman100BecomesC()
        {
            Assert.AreEqual("C", _roman.ToRoman(100));
        }

        [TestMethod]
        public void WhenConvertingToRoman400BecomesCD()
        {
            Assert.AreEqual("CD", _roman.ToRoman(400));
        }

        [TestMethod]
        public void WhenConvertingToRoman500BecomesD()
        {
            Assert.AreEqual("D", _roman.ToRoman(500));
        }

        [TestMethod]
        public void WhenConvertingToRoman900BecomesCM()
        {
            Assert.AreEqual("CM", _roman.ToRoman(900));
        }

        [TestMethod]
        public void WhenConvertingToRoman1000BecomesM()
        {
            Assert.AreEqual("M", _roman.ToRoman(1000));
        }

        [TestMethod]
        public void WhenConvertingToRomanRunTestCasesFromKataDefinition()
        {
            Assert.AreEqual("I", _roman.ToRoman(1));
            Assert.AreEqual("III", _roman.ToRoman(3));
            Assert.AreEqual("IX", _roman.ToRoman(9));
            Assert.AreEqual("MLXVI", _roman.ToRoman(1066));
            Assert.AreEqual("MCMLXXXIX", _roman.ToRoman(1989));
        }

        [TestMethod]
        public void WhenConvertingToArabicNullOrBlankOrWhiteSpaceIsZero()
        {
            Assert.AreEqual(0, _roman.ToArabic(null));
            Assert.AreEqual(0, _roman.ToArabic(String.Empty));
            Assert.AreEqual(0, _roman.ToArabic("   "));
            Assert.AreEqual(0, _roman.ToArabic("\t"));
        }

        [TestMethod]
        public void WhenConvertingToArabicLeadingAndTrailingWhiteSpaceIsIgnored()
        {
            Assert.AreEqual(1, _roman.ToArabic(" I "));
        }

        [TestMethod]
        public void WhenConvertingToArabicIBecomes1()
        {
            Assert.AreEqual(1, _roman.ToArabic("I"));
        }

        [TestMethod]
        public void WhenConvertingToArabicIVBecomes4()
        {
            Assert.AreEqual(4, _roman.ToArabic("IV"));
        }

        [TestMethod]
        public void WhenConvertingToArabicVBecomes5()
        {
            Assert.AreEqual(5, _roman.ToArabic("V"));
        }

        [TestMethod]
        public void WhenConvertingToArabicIXBecomes9()
        {
            Assert.AreEqual(9, _roman.ToArabic("IX"));
        }

        [TestMethod]
        public void WhenConvertingToArabicXBecomes10()
        {
            Assert.AreEqual(10, _roman.ToArabic("X"));
        }

        [TestMethod]
        public void WhenConvertingToArabicXLBecomes40()
        {
            Assert.AreEqual(40, _roman.ToArabic("XL"));
        }

        [TestMethod]
        public void WhenConvertingToArabicLBecomes50()
        {
            Assert.AreEqual(50, _roman.ToArabic("L"));
        }

        [TestMethod]
        public void WhenConvertingToArabicXCBecomes90()
        {
            Assert.AreEqual(90, _roman.ToArabic("XC"));
        }

        [TestMethod]
        public void WhenConvertingToArabicCBecomes100()
        {
            Assert.AreEqual(100, _roman.ToArabic("C"));
        }

        [TestMethod]
        public void WhenConvertingToArabicCDBecomes400()
        {
            Assert.AreEqual(400, _roman.ToArabic("CD"));
        }

        [TestMethod]
        public void WhenConvertingToArabicDBecomes500()
        {
            Assert.AreEqual(500, _roman.ToArabic("D"));
        }

        [TestMethod]
        public void WhenConvertingToArabicCMBecomes900()
        {
            Assert.AreEqual(900, _roman.ToArabic("CM"));
        }

        [TestMethod]
        public void WhenConvertingToArabicMBecomes1000()
        {
            Assert.AreEqual(1000, _roman.ToArabic("M"));
        }
    }
}
