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
        public void DeckContainsAceOfSpadesByDefault()
        {
            Card card = new Card(Card.Suit.spades, Card.Rank.Ace);
            Deck deck = new Deck();

            Assert.AreEqual(0, deck.Cards[0].CompareTo(card));
        }


        [Test]
        public void DeckContainsMultipleSpadesByDefault()
        {
            Card card1 = new Card(Card.Suit.spades, Card.Rank.Ace);
            Card card2 = new Card(Card.Suit.spades, Card.Rank.King);
            Card card3 = new Card(Card.Suit.spades, Card.Rank.Queen);
            Deck deck = new Deck();

            Assert.AreEqual(true, deck.Cards.Contains(card1) 
                && deck.Cards.Contains(card2) 
                && deck.Cards.Contains(card3));
        }
    }
}
