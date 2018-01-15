using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfArray;

namespace ArrayOperationsTest
{
    [TestClass]
    public class SumOfArrayTest
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
    }
}
