using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkLibrary;

namespace HWTests
{
    public class VariablesHelperTests
    {

        [TestCase(3, 2, 5)]
        [TestCase(2, 5, -3)]
        [TestCase(4, 4, 16)]
        public void Compare_WhenCalculate(
          double a,
          double b,
          double expectedResult)
        {
            double actualResult = HWLibrary.Compare(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(3, 2, 1)]
        [TestCase(-3, 5, 2)]
        [TestCase(-8, -4, 3)]
        [TestCase(6, -3, 4)]
        public void Quadrant_WhenPointIsNotOnAxis(
          double a,
          double b,
          double expectedResult)
        {
            double actualResult = HWLibrary.Quadrant(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 0)]
        [TestCase(0, 5)]
        public void Qadrant_WhenPointIsOnAxis(
            double a,
            double b)
        {
            try
            {
                HWLibrary.Quadrant(a, b);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Point is on axial", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(3, 2, 1)]
        [TestCase(3, 10, 1)]
        [TestCase(4, 6, 12)]
        [TestCase(4, 4, 12)]
        [TestCase(16, 4, 4)]
        [TestCase(10, 4, 10)]
        [TestCase(5, 5, 5)]
        public void SortAsc_WhenLogicWork(
          double a,
          double b,
          double c)
        {
            HWLibrary.SortAsc(ref a, ref b, ref c);

            Assert.IsTrue(a <= b);
            Assert.IsTrue(b <= c);
            Assert.IsTrue(a <= c);
        }

        [TestCase(10, 100, 50, -9.47, -0.53)]
        public void QuadraticEquation_WhenRealRootsExists(
          double a,
          double b,
          double c,
          double x1,
          double x2)
        {
            (double x1Actual, double x2Actual) = HWLibrary.QuadraticEquation(a, b, c);

            Assert.AreEqual(Math.Round(x1Actual, 2), x1);
            Assert.AreEqual(Math.Round(x2Actual, 2), x2);
        }

        [TestCase(10, 1, 50)]
        public void QuadraticEquation_WhenNoRealRootsExists(
          double a,
          double b,
          double c)
        {
            try
            {
                HWLibrary.QuadraticEquation(a, b, c);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Quadratic equation has no real roots!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(0, 1, 50)]
        public void QuadraticEquation_WhenAEqualsZero(
          double a,
          double b,
          double c)
        {
            try
            {
                HWLibrary.QuadraticEquation(a, b, c);
            }
            catch (DivideByZeroException ex)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(51, "fifty one")]
        [TestCase(15, "fifteen")]
        public void NumbersInWords_WhenNumberIsMoreZero(
         int a,
         string expectedResult)
        {
            string actualResult  = HWLibrary.NumbersInWords(a);

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void NumbersInWords_WhenNumberLessThanZero()
        {
            try
            {
                HWLibrary.NumbersInWords(-50);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The number must be greater than 0!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        public void NumbersInWords_WhenNumberLessThanTen()
        {
            try
            {
                HWLibrary.NumbersInWords(5);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The number must be greater than 10!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

    }
}