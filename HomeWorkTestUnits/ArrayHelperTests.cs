using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkLibrary;
using HomeWorkTestUnits;

namespace HWTests
{
    public class ArrayHelperTests
    {
        public class ArraysHelperTests
        {
            [TestCase(new int[] { }, new int[] { })]
            [TestCase(new[] { 1 }, new[] { 1 })]
            [TestCase(new[] { 1, 5 }, new[] { 5, 1 })]
            [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
            public void Reverse_WhenArrayNotNull_ShouldReverseArray(
                int[] sourceArray,
                int[] expectedArray)
            {
                HWLibrary.ReverseArray(ref sourceArray);

                Assert.AreEqual(expectedArray, sourceArray);
            }

            [TestCase(new[] { 1 }, 1)]
            [TestCase(new[] { 1, 5 }, 1)]
            [TestCase(new[] { 1, 2, 3, 4, 5 }, 1)]
            public void MinElement_WhenArrayNotNull_ShouldFindMin(
                int[] sourceArray,
                int expectedResult)
            {
                int actualResult = HWLibrary.MinElement(sourceArray);

                Assert.AreEqual(actualResult, expectedResult);
            }

            [Test]
            public void MinElement_WhenArrayNull_ShouldThrowArgumentException()
            {
                try
                {
                    HWLibrary.MinElement(new int[] { });
                }
                catch (ArgumentNullException ex)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }

            [TestCase(new[] { 1 }, 1)]
            [TestCase(new[] { 1, 5 }, 5)]
            [TestCase(new[] { 1, 2, 3, 4, 5 }, 5)]
            public void MaxElement_WhenArrayNotNull_ShouldFindMin(
               int[] sourceArray,
               int expectedResult)
            {
                int actualResult = HWLibrary.MaxElement(sourceArray);

                Assert.AreEqual(actualResult, expectedResult);
            }

            [Test]
            public void MaxElement_WhenArrayNull_ShouldThrowArgumentException()
            {
                try
                {
                    HWLibrary.MaxElement(new int[] { });
                }
                catch (ArgumentNullException ex)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }

            [TestCase(new[] { 1 }, 1)]
            [TestCase(new[] { 1, 5 }, 1)]
            [TestCase(new[] { 1, 2, 3, 4, 5 }, 1)]
            public void MinElementIndex_WhenArrayNotNull_ShouldFindMinIndex(
                int[] sourceArray,
                int expectedResult)
            {
                int actualResult = HWLibrary.MinElement(sourceArray);

                Assert.AreEqual(actualResult, expectedResult);
            }

            [Test]
            public void MinElementIndex_WhenArrayNull_ShouldThrowArgumentException()
            {
                try
                {
                    HWLibrary.MinElement(new int[] { });
                }
                catch (ArgumentNullException ex)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }

            [TestCase(new[] { 1 }, 1)]
            [TestCase(new[] { 1, 5 }, 5)]
            [TestCase(new[] { 1, 2, 3, 4, 5 }, 5)]
            public void MaxElementIndex_WhenArrayNotNull_ShouldFindMinIndex(
               int[] sourceArray,
               int expectedResult)
            {
                int actualResult = HWLibrary.MaxElement(sourceArray);

                Assert.AreEqual(actualResult, expectedResult);
            }

            [Test]
            public void MaxElementIndex_WhenArrayNull_ShouldThrowArgumentException()
            {
                try
                {
                    HWLibrary.MaxElement(new int[] { });
                }
                catch (ArgumentNullException ex)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }

            [TestCase(new int[] { }, new int[] { })]
            [TestCase(new[] { 1 }, new[] { 1 })]
            [TestCase(new[] { 56, 8, 12, 4, 22 }, new[] { 4, 8, 12, 22, 56 })]
            public void SelectionSortArrayAsc_ShouldSortArray(
                int[] sourceArray,
                int[] expectedArray)
            {
                HWLibrary.SelectionSortArrayAsc(ref sourceArray);

                Assert.AreEqual(expectedArray, sourceArray);
            }

            [TestCase(new int[] { }, new int[] { })]
            [TestCase(new[] { 1 }, new[] { 1 })]
            [TestCase(new[] { 56, 8, 12, 4, 22 }, new[] { 4, 8, 12, 22, 56 })]
            public void InsertionSortArrayDesc_ShouldSortArray(
                int[] sourceArray,
                int[] expectedArray)
            {
                HWLibrary.SelectionSortArrayAsc(ref sourceArray);

                Assert.AreEqual(expectedArray, sourceArray);
            }

            [TestCaseSource(nameof(ReverseElementsCases))]
            public void ReverseArrayByDiagonal_ShouldReverseArray(
            int[,] sourceArray,
            int[,] expectedArray)
            {
                HWLibrary.ReverseArrayByDiagonal(ref sourceArray);

                Assert.AreEqual(expectedArray, sourceArray);
            }

            [TestCaseSource(nameof(AdjacentElementsCases))]
            public void MoreThanAdjacentElementsCount_WhenArrayNotNull_ShouldCount(
               int[,] sourceArray,
               int expectedResult)
            {
                int actualResult = HWLibrary.MoreThanAdjacentElementsCount(sourceArray);

                Assert.AreEqual(actualResult, expectedResult);
            }

            [Test]
            public void MoreThanAdjacentElementsCount_WhenArrayNull_ShouldThrowArgumentException()
            {
                try
                {
                    HWLibrary.MoreThanAdjacentElementsCount(new int[,] { {} , {} });
                }
                catch (ArgumentNullException ex)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }

            [TestCaseSource(typeof(MaxArrayTestsScenarios))]
            public void Max_WhenArrayIsFilled_ShouldReturnMaxFromArray(
               int[,] sourceArray,
               int expectedMax)
            {
                int actualMax = HWLibrary.MaxElement(sourceArray);

                Assert.AreEqual(expectedMax, actualMax);
            }

            [TestCaseSource(nameof(MinCases))]
            public void Min_WhenArrayIsFilled_ShouldReturnMinFromArray(
            int[,] sourceArray,
            int expectedMin)
            {
                int actualMin = HWLibrary.MinElement(sourceArray);

                Assert.AreEqual(expectedMin, actualMin);
            }

            static object[] MinCases = new[]
            {
            new object[] { new[,] { { 1, 2, 3 }, { 4, 5, 6} }, 1 },
            new object[] { new[,] { { 4, 5, 6}, { 6, 7, 8} }, 4 }
            };

            static object[] AdjacentElementsCases = new[]
            {
            new object[] { new[,] { { 20, 2, 3 , 4 }, { 5, 6, 7, 8}, { 9, 10, 11, 12 } }, 2 },
            new object[] { new[,] { { 4, 5, 6}, { 6, 7, 8} }, 1 },
            };

            static object[] ReverseElementsCases = new[]
{
            new object[] { new[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } } , 
                           new[,] { { 1, 5, 9, 13 }, { 2, 6, 10, 14 }, { 3, 7, 11, 15 }, { 4, 8, 12, 16 } } }
            };


        }

       
    }
}