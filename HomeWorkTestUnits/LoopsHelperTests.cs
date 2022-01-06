using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkLibrary;

namespace HWTests
{
    public class LoopsHelperTests
    {
        [TestCase(2, 3, 8)]
        [TestCase(2, 1, 2)]
        [TestCase(8, -2, 0.015625)]
        public void ADegreeB_WhenAAndBPassed_ShouldCalculateDegree(
         int a,
         int b,
         double expectedResult)
        {
            double actualResult = HWLibrary.ADegreeB(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ADegreeB_WhenALessThanZero()
        {
            try
            {
                HWLibrary.ADegreeB(-10, 3);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The number A must be greater than 0!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(10, 3)]
        [TestCase(185, 13)]
        public void RealNumberCountSquareMoreThanA_WhenAPassed_ShouldCalculate(
         int a,
         int expectedResult)
        {
            double actualResult = HWLibrary.RealNumberCountSquareMoreThanA(a);

            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void RealNumberCountSquareMoreThanA_WhenALessThanZero()
        {
            try
            {
                HWLibrary.ADegreeB(-10, 0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The number A must be greater than 0!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(682, 341)]
        [TestCase(21, 7)]
        public void MaxDivisor_WhenAPassed_ShouldCalculate(
         int a,
         int expectedResult)
        {
            double actualResult = HWLibrary.MaxDivisor(a);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void MaxDivisor_WhenALessThanZero()
        {
            try
            {
                HWLibrary.MaxDivisor(-10);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The number must be greater than 0!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(3, 10, 7)]
        [TestCase(15, 1, 21)]
        [TestCase(1, 6, 0)]
        [TestCase(7, 14, 21)]
        [TestCase(7, 7, 7)]
        [TestCase(1, 1, 0)]
        [TestCase(6, 27, 42)]
        public void SumFromAToBWhichDivideBySeven_WhenAAndBPassed_ShouldCalculateSum(
             int a,
             int b,
             int expectedResult)
        {
            int actualResult = HWLibrary.DivisibleBy7(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(2, 1)]
        [TestCase(10, 55)]
        [TestCase(16, 987)]
       
        public void FibonacciNNumber_WhenNPassed_ShouldCalculate(
        int n,
        int expectedResult)
        {
            double actualResult = HWLibrary.FibonacciNNumber(n);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void FibonacciNNumber_WhenNLessThanZero()
        {
            try
            {
                HWLibrary.FibonacciNNumber(-10);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The number must be greater than 0!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}