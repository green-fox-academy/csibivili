using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyPlusOneApp;

namespace TwentyPlusOneAppTest
{
    [TestFixture]
    public class TwentyPlusOneTest
    {
        [Test]
        public void SmokeTestForConstructor()
        {
            Deck deck = new Deck();
        }
    }
}
