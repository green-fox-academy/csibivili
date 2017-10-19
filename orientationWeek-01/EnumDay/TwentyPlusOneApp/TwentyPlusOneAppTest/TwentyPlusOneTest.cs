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

        [Test]
        public void DeckContainsTwoOfSpadesByDefault()
        {
            Card card = new Card(Card.Suit.spades, Card.Rank.two, Card.Color.black);
            Deck deck = new Deck();

            Assert.AreEqual(0, deck.Cards[0].CompareTo(card));
        }


        [Test]
        public void DeckContainsMultipleSpadesByDefault()
        {
            Card card1 = new Card(Card.Suit.spades, Card.Rank.two, Card.Color.black);
            Card card2 = new Card(Card.Suit.spades, Card.Rank.three, Card.Color.black);
            Card card3 = new Card(Card.Suit.spades, Card.Rank.four, Card.Color.black);
            Deck deck = new Deck();

            Assert.AreEqual(0, deck.Cards[0].CompareTo(card1)
                + deck.Cards[1].CompareTo(card2)
                + deck.Cards[2].CompareTo(card3));
        }
    }
}
