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
            var output = input;

            Assert.AreEqual(output, sum.SumOfNumbers());
        }
    }
}
