using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorDemo.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator calc = new Calculator();

        [TestMethod]
        public void EmptyString()
        {
            int expected = 0;
            int actual = calc.Add("");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SingleDigitZero()
        {
            int expected = 0;
            int actual = calc.Add("0");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SingleDigitOne()
        {
            int expected = 1;
            int actual = calc.Add("1");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SingleDigitTwo()
        {
            int expected = 2;
            int actual = calc.Add("2");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SingleRandomDigit()
        {
            Random random = new Random();
            int expected = random.Next(0, 1000);
            int actual = calc.Add(expected.ToString());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneAndTwo()
        {
            int expected = 3;
            int actual = calc.Add("1,2");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TenAndTwelve()
        {
            int expected = 22;
            int actual = calc.Add("10,12");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneTwoAndThree()
        {
            int expected = 6;
            int actual = calc.Add("1,2,3");
            Assert.AreEqual(expected, actual);
        }
    }
}
