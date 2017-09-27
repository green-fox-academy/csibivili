using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum;

namespace SumTest
{
    [TestFixture]
    public class SumNumbersTest
    {
        SumNumbers sum = new SumNumbers();

        [Test]
        public void TestSumNumbersWhenNumberOfInputs1OutputEqualToInput ()
        {
            var input = new List<int> { 1 };
            var output = input[0];

            Assert.AreEqual(output, sum.SumOfNumbers(input));
        }

        [Test]
        public void TestSumNumbersWhenNumberOfInputsMoreThan1()
        {
            var input = new List<int> { 1,2 ,3};
            int output = input.Sum();

            Assert.AreEqual(output, sum.SumOfNumbers(input));
        }

        [Test]
        public void TestSumNumbersWhenNumberOfInputs0()
        {
            var input = new List<int>();
            int output = 0;

            Assert.AreEqual(output, sum.SumOfNumbers(input));
        }

        [Test]
        public void TestSumNumbersWhenNullInput()
        {
            var input = new List<int> {};
            int output = 0;

            Assert.AreEqual(output, sum.SumOfNumbers(input));
        }
    }
}
