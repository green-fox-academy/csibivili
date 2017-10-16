using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerTDD;

namespace PokerAppTest
{
    [TestFixture]
    public class PokerTest
    {
        [Test]
        public void TestWhenWhiteWinsByHighCard()
        {
            string black = "2H 3D 5S 9C KD";
            string white = "2C 3H 4S 8C AH";
            string output = "White wins. - with high card: Ace";

            Assert.AreEqual(output, Poker.ComparePlayers(black, white));
        }
        [Test]
        public void TestWhenBothHaveOneAce()
        {
            string black = "2H 3D 5S 9C AD";
            string white = "2C 3H 4S 8C AH";
            string output = "Black wins. - with high card: Nine";

            Assert.AreEqual(output, Poker.ComparePlayers(black, white));

            black = "2H 3D 9S AC AD";
            white = "2C 3H 4S AS AH";
            output = "Black wins. - with high card: Nine";

            Assert.AreEqual(output, Poker.ComparePlayers(black, white));
        }
        [Test]
        public void TestWhenWhiteWinsByFlush()
        {
            string black = "2H 4S 4C 2D 4H";
            string white = "2S 8S AS QS 3S";
            string output = "White wins. - with flush";

            Assert.AreEqual(output, Poker.ComparePlayers(black, white));
        }
        [Test]
        public void TestWhenBlackWinsByFlush()
        {
            string black = "2H 4H 5H 7H TH";
            string white = "2S 8C AS QS 3S";
            string output = "Black wins. - with flush";

            Assert.AreEqual(output, Poker.ComparePlayers(black, white));
        }
        [Test]
        public void TestWhenBlackAndWhiteHaveTheSameFlush()
        {
            string black = "2H 4H 5H 7H TH";
            string white = "6H 8H AH QH 3H";
            string output = "White wins. - with higher flush";

            Assert.AreEqual(output, Poker.ComparePlayers(black, white));
        }
    }
}
