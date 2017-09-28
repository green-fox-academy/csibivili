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

        [Test]
        public void TestCABWhen1678()
        {
            int input = 1678;
            string output = "cow678";

            Assert.AreEqual(output, cowsAndBulls.CAB(input));
        }

        [Test]
        public void TestCABWhen5278()
        {
            int input = 5278;
            string output = "5cow78";

            Assert.AreEqual(output, cowsAndBulls.CAB(input));
        }

        [Test]
        public void TestCABWhen5274()
        {
            int input = 5274;
            string output = "5cow7cow";

            Assert.AreEqual(output, cowsAndBulls.CAB(input));
        }

        [Test]
        public void TestCABWhen5672()
        {
            int input = 5672;
            string output = "567bull";

            Assert.AreEqual(output, cowsAndBulls.CAB(input));
        }

        [Test]
        public void TestCABWhen5612()
        {
            int input = 5612;
            string output = "56bullbull";

            Assert.AreEqual(output, cowsAndBulls.CAB(input));
        }

        [Test]
        public void TestCABWhen2612()
        {
            int input = 2612;
            string output = "bull6bullbull";

            Assert.AreEqual(output, cowsAndBulls.CAB(input));
        }

        [Test]
        public void TestCABWhen5432()
        {
            int input = 5432;
            string output = "5bullcowbull";

            Assert.AreEqual(output, cowsAndBulls.CAB(input));
        }

        [Test]
        public void TestCABWhen4321()
        {
            int input = 4321;
            string output = "bullbullbullbull";

            Assert.AreEqual(output, cowsAndBulls.CAB(input));
        }

        [Test]
        public void TestCABWhen4231()
        {
            int input = 4231;
            string output = "bullcowcowbull";

            Assert.AreEqual(output, cowsAndBulls.CAB(input));
        }
    }
}
