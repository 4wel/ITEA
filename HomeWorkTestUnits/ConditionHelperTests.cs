using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkLibrary;

namespace HWTests
{
    public class ConditionHelperTests
    {
        [TestCase(2, 3)]
        public void SwapDouble(
            double a,
            double b)
        {
            double x = a;
            double y = b;
            HWLibrary.SwapDouble(ref a, ref b);

            Assert.AreEqual(x, b);
            Assert.AreEqual(y, a);
            Assert.Pass();
        }

        [TestCase(2, 3)]
        public void Swap(
        int a,
        int b)
        {
            int x = a;
            int y = b;
            HWLibrary.Swap(ref a, ref b);

            Assert.AreEqual(x, b);
            Assert.AreEqual(y, a);
            Assert.Pass();
        }

        [TestCase(2, 3, 19)]
        [TestCase(3, 5, 20)]
        public void CalculateEquation_WhenANotEqualToB_ShouldCalculateEquation(
            double a,
            double b,
            double expectedResult)
        {
            double actualResult = HWLibrary.CalculateEquation(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CalculateEquation_WhenAEqualToB_ShouldThrowArgumentException()
        {
            try
            {
                HWLibrary.CalculateEquation(1, 1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A equal to B!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }


        [TestCase(10, 3, 3, 1)]
        public void IntegerDivisionRemainderParts_WhenANotEqualToB_ShouldCalculateEquation(
            int a,
            int b,
            int integerPart, 
            double divisionRemainder)
        {

            (int aActual, double bActual) = HWLibrary.IntegerDivisionRemainderParts(a, b);
            
            Assert.AreEqual(aActual, integerPart);
            Assert.AreEqual(bActual, divisionRemainder);
        }

        [Test]
        public void IntegerDivisionRemainderParts_WhenAEqualToB_ShouldThrowArgumentException()
        {
            try
            {
                HWLibrary.CalculateEquation(1, 1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A equal to B!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }


        [TestCase(2, 5, 10, 2.5)]
        public void CalculateEquation2_WhenANotEqualZero_ShouldCalculateEquation(
          int a,
          int b,
          int c,
          double expectedResult)
        {
            double actualResult = HWLibrary.CalculateEquation2(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CalculateEquation2_WhenAEqualZero_ShouldCalculateEquation()
        {
            try
            {
                HWLibrary.CalculateEquation2(0, 1, 3);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A equal zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(50, 20, 120, 75, 0.79, -19.29)]
        public void LineCoefficients_WhenANotEqualToB_ShouldCalculateEquation(
           int x1,
           int y1,
           int x2,
           int y2,
           double a,
           double b)
        {
            (double aActual, double bActual) = HWLibrary.LineCoefficients(x1, y1, x2, y2);

            Assert.AreEqual(Math.Round(aActual,2), a);
            Assert.AreEqual(Math.Round(bActual,2), b);
        }

        [Test]
        public void LineCoefficients_WhenAEqualToB_ShouldThrowArgumentException()
        {
            try
            {
                HWLibrary.LineCoefficients(10, 50, 10, 30);
            }
            catch (DivideByZeroException ex)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        

    }
}