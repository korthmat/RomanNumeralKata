using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralKata;
using System;

namespace RomanNumeralKataTests
{
    [TestClass]
    public class ToArabicTests
    {
        private RomanNumeral _roman;

        public ToArabicTests()
        {
            _roman = new RomanNumeral();
        }

        [TestMethod]
        public void NullOrBlankOrWhiteSpaceIsZero()
        {
            Assert.AreEqual(0, _roman.ToArabic(null));
            Assert.AreEqual(0, _roman.ToArabic(String.Empty));
            Assert.AreEqual(0, _roman.ToArabic("   "));
            Assert.AreEqual(0, _roman.ToArabic("\t"));
        }

        [TestMethod]
        public void LeadingAndTrailingWhiteSpaceIsIgnored()
        {
            Assert.AreEqual(1, _roman.ToArabic(" I "));
        }

        [TestMethod]
        public void RomanIBecomes1()
        {
            Assert.AreEqual(1, _roman.ToArabic("I"));
        }

        [TestMethod]
        public void RomanIVBecomes4()
        {
            Assert.AreEqual(4, _roman.ToArabic("IV"));
        }

        [TestMethod]
        public void RomanVBecomes5()
        {
            Assert.AreEqual(5, _roman.ToArabic("V"));
        }

        [TestMethod]
        public void RomanIXBecomes9()
        {
            Assert.AreEqual(9, _roman.ToArabic("IX"));
        }

        [TestMethod]
        public void RomanXBecomes10()
        {
            Assert.AreEqual(10, _roman.ToArabic("X"));
        }

        [TestMethod]
        public void RomanXLBecomes40()
        {
            Assert.AreEqual(40, _roman.ToArabic("XL"));
        }

        [TestMethod]
        public void RomanLBecomes50()
        {
            Assert.AreEqual(50, _roman.ToArabic("L"));
        }

        [TestMethod]
        public void RomanXCBecomes90()
        {
            Assert.AreEqual(90, _roman.ToArabic("XC"));
        }

        [TestMethod]
        public void RomanCBecomes100()
        {
            Assert.AreEqual(100, _roman.ToArabic("C"));
        }

        [TestMethod]
        public void RomanCDBecomes400()
        {
            Assert.AreEqual(400, _roman.ToArabic("CD"));
        }

        [TestMethod]
        public void RomanDBecomes500()
        {
            Assert.AreEqual(500, _roman.ToArabic("D"));
        }

        [TestMethod]
        public void RomanCMBecomes900()
        {
            Assert.AreEqual(900, _roman.ToArabic("CM"));
        }

        [TestMethod]
        public void RomanMBecomes1000()
        {
            Assert.AreEqual(1000, _roman.ToArabic("M"));
        }
    }
}
