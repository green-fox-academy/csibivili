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
        public void TestCABWhen1234()
        {
            int input = 1234;
            string output = "cowcowcowcow";

            Assert.AreEqual(output, cowsAndBulls.CAB(input));
        }

        [Test]
        public void TestCABWhen5678()
        {
            int input = 5678;
            string output = "5678";

            Assert.AreEqual(output, cowsAndBulls.CAB(input));
        }
    }
}
