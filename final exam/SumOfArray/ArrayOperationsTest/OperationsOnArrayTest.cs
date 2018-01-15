using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfArray;
using System.Collections.Generic;

namespace ArrayOperationsTest
{
    [TestClass]
    public class OperationsOnArrayTest
    {
        [TestMethod]
        public void WhenArrayHasZeroElementReturnWithZero()
        {
            int[] array = new int[0];
            int result = ArrayOperations.Sum(array);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void WhenArrayHasOneElementReturnWithTheValueOfElement()
        {
            int[] array = new int[] {5};

            int result = ArrayOperations.Sum(array);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void WhenArrayHasMoreElementsReturnWithTheSumOfElements()
        {
            int[] array = new int[] { 5, 6, 7 };

            int result = ArrayOperations.Sum(array);

            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void WhenArrayHasNegativeElements()
        {
            int[] array = new int[] { -5, 6, 7 };

            int result = ArrayOperations.Sum(array);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void WhenArrayHasZeroElementReturnWithZeroAverage()
        {
            int[] array = new int[0];
            float result = ArrayOperations.Average(array);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void WhenArrayHasOneElementReturnWithTheExactValueOfElement()
        {
            int[] array = new int[] { 5 };

            float result = ArrayOperations.Average(array);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void WhenArrayHasOneEvenElementReturnWithTheValueOfElement()
        {
            int[] array = new int[] { 6 };

            List<int> result = ArrayOperations.EvenNumbers(array);

            Assert.AreEqual(6, result[0]);
        }

        [TestMethod]
        public void WhenArrayHasOneEvenAndOneOddElementReturnWithTheEvenOne()
        {
            int[] array = new int[] { 6, 7 };

            List<int> result = ArrayOperations.EvenNumbers(array);

            Assert.AreEqual(6, result[0]);
        }

        [TestMethod]
        public void WhenArrayHasZeroElementReturnWithEmptyList()
        {
            int[] array = new int[0];
            List<int> result = ArrayOperations.EvenNumbers(array);

            Assert.AreEqual(0, result.Count);
        }


        [TestMethod]
        public void WhenArrayHasTwoEvenAndOneOddElementReturnWithTheAverageOfEvenOnes()
        {
            int[] array = new int[] { 6, 7, 8 };

            float result = ArrayOperations.AverageOfEvenNumbers(array);

            Assert.AreEqual(7, result);
        }
    }
}
