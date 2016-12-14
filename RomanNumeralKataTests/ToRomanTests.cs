using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralKata;

namespace RomanNumeralKataTests
{
    [TestClass]
    public class ToRomanTests
    {
        private RomanNumeral _roman;

        public ToRomanTests()
        {
            _roman = new RomanNumeral();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeNumbersThrowOutOfRange()
        {
            _roman.ToRoman(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ZeroThrowsOutOfRange()
        {
            _roman.ToRoman(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GreaterThan4000ThrowsOutOfRange()
        {
            _roman.ToRoman(4321);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EqualTo4000ThrowsOutOfRange()
        {
            _roman.ToRoman(4000);
        }

        [TestMethod]
        public void Arabic1BecomesI()
        {
            Assert.AreEqual("I", _roman.ToRoman(1));
        }

        [TestMethod]
        public void Arabic4BecomesIV()
        {
            Assert.AreEqual("IV", _roman.ToRoman(4));
        }

        [TestMethod]
        public void Arabic5BecomesV()
        {
            Assert.AreEqual("V", _roman.ToRoman(5));
        }

        [TestMethod]
        public void Arabic9BecomesIX()
        {
            Assert.AreEqual("IX", _roman.ToRoman(9));
        }

        [TestMethod]
        public void Arabic10BecomesX()
        {
            Assert.AreEqual("X", _roman.ToRoman(10));
        }

        [TestMethod]
        public void Arabic40BecomesXL()
        {
            Assert.AreEqual("XL", _roman.ToRoman(40));
        }

        [TestMethod]
        public void Arabic50BecomesL()
        {
            Assert.AreEqual("L", _roman.ToRoman(50));
        }

        [TestMethod]
        public void Arabic90BecomesXC()
        {
            Assert.AreEqual("XC", _roman.ToRoman(90));
        }

        [TestMethod]
        public void Arabic100BecomesC()
        {
            Assert.AreEqual("C", _roman.ToRoman(100));
        }

        [TestMethod]
        public void Arabic400BecomesCD()
        {
            Assert.AreEqual("CD", _roman.ToRoman(400));
        }

        [TestMethod]
        public void Arabic500BecomesD()
        {
            Assert.AreEqual("D", _roman.ToRoman(500));
        }

        [TestMethod]
        public void Arabic900BecomesCM()
        {
            Assert.AreEqual("CM", _roman.ToRoman(900));
        }

        [TestMethod]
        public void Arabic1000BecomesM()
        {
            Assert.AreEqual("M", _roman.ToRoman(1000));
        }

        [TestMethod]
        public void RunTestCasesFromKataDefinition()
        {
            Assert.AreEqual("I", _roman.ToRoman(1));
            Assert.AreEqual("III", _roman.ToRoman(3));
            Assert.AreEqual("IX", _roman.ToRoman(9));
            Assert.AreEqual("MLXVI", _roman.ToRoman(1066));
            Assert.AreEqual("MCMLXXXIX", _roman.ToRoman(1989));
        }
    }
}
