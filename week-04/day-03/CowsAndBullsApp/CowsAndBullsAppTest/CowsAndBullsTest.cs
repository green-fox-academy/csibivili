using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CowsAndBullsApp;
using NUnit.Framework;

namespace CowsAndBullsAppTest
{
    [TestFixture]
    public class CowsAndBullsTest
    {
        CowsAndBulls cowsAndBulls = new CowsAndBulls();

        [Test]
        public void TestCABWhen1111()
        {
            int input = 1111;
            string output = "cowcowcowcow";

            Assert.AreEqual(output, cowsAndBulls.CAB(input));
        }
    }
}
