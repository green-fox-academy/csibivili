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
            Card card = new Card(Card.Suit.Spades, 
                Card.Rank.Two, Card.Color.black);
            Deck deck = new Deck();

            Assert.AreEqual(0, deck.Cards[0].CompareTo(card));
        }


        [Test]
        public void DeckContainsMultipleSpadesByDefault()
        {
            Card card1 = new Card(Card.Suit.Spades, 
                Card.Rank.Two, Card.Color.black);
            Card card2 = new Card(Card.Suit.Spades, 
                Card.Rank.Three, Card.Color.black);
            Card card3 = new Card(Card.Suit.Spades, 
                Card.Rank.Four, Card.Color.black);
            Deck deck = new Deck();

            Assert.AreEqual(0, deck.Cards[0].CompareTo(card1)
                + deck.Cards[1].CompareTo(card2)
                + deck.Cards[2].CompareTo(card3));
        }

        [Test]
        public void NotShuffledDeck()
        {
            Deck deck = new Deck();
            Deck deck2 = new Deck();

            Assert.AreEqual(0, deck.Cards[0].CompareTo(deck2.Cards[0]));
        }

        [Test]
        public void ShuffledDeck()
        {
            Deck deck = new Deck();
            Deck deck2 = new Deck();

            List<Card> deck3 = Deck.ShuffleDeck(deck2.Cards);

            Assert.AreNotEqual(0, deck.Cards[0].CompareTo(deck3[0]));
        }

        [Test]
        public void PullFirstCard()
        {
            Card card = new Card(Card.Suit.Spades, 
                Card.Rank.Two, Card.Color.black);
            Deck deck = new Deck();

            Assert.AreEqual(0, deck.Cards[0].CompareTo(Deck.PullFirst(deck)));
        }

        [Test]
        public void PullLastCard()
        {
            Card card = new Card(Card.Suit.Spades,
                Card.Rank.Two, Card.Color.black);
            Deck deck = new Deck();

            Assert.AreEqual(0, deck.Cards[deck.Cards.Count() - 1].
                CompareTo(Deck.PullLast(deck)));
        }

        [Test]
        public void PullRandomCard()
        {
            Card card = new Card(Card.Suit.Spades,
                Card.Rank.Two, Card.Color.black);
            Deck deck = new Deck();

            Assert.AreNotEqual(0, deck.Cards[0].
                CompareTo(Deck.PullRandom(deck)));
        }

        [Test]
        public void NumberOfHand()
        {
            Game game = new Game(2);

            game.Deal(game, 2);

            int numberOfCards = game.Players[0].Hand.Count();

            Assert.AreEqual(2, numberOfCards);
        }

        [Test]
        public void NumberOfRemainingCards()
        {
            Game game = new Game(3);

            int numberOfCards = game.Cards.Cards.Count();

            game.Deal(game, 2);

            int numberOfRemainingCards = game.Cards.Cards.Count();

            Assert.AreEqual(8, numberOfCards - numberOfRemainingCards);
        }
    }
}
