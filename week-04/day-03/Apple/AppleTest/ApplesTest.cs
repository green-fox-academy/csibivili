using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apple;

namespace AppleTest
{
    [TestFixture]
    public class ApplesTest
    {
        Apples apple = new Apples();

        [Test]
        public void TestApple_ReturnApple ()
        {
            Assert.AreEqual("apple", apple.PrintApple());
        }
    }
}
