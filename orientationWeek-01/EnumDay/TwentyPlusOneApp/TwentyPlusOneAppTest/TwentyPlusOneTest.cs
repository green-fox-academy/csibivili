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
                Card.Rank.Two, Card.Color.Black);
            Deck deck = new Deck();

            Assert.AreEqual(0, deck.Cards[0].CompareTo(card));
        }


        [Test]
        public void DeckContainsMultipleSpadesByDefault()
        {
            Card card1 = new Card(Card.Suit.Spades, 
                Card.Rank.Two, Card.Color.Black);
            Card card2 = new Card(Card.Suit.Spades, 
                Card.Rank.Three, Card.Color.Black);
            Card card3 = new Card(Card.Suit.Spades, 
                Card.Rank.Four, Card.Color.Black);
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
                Card.Rank.Two, Card.Color.Black);
            Deck deck = new Deck();

            Assert.AreEqual(0, card.CompareTo(Deck.PullFirst(deck.Cards)));
        }

        [Test]
        public void PullLastCard()
        {
            Card card = new Card(Card.Suit.Diamonds,
                Card.Rank.Ace, Card.Color.Red);
            Deck deck = new Deck();

            Assert.AreEqual(0, card.
                CompareTo(Deck.PullLast(deck.Cards)));
        }

        [Test]
        public void PullRandomCard()
        {
            Card card = new Card(Card.Suit.Spades,
                Card.Rank.Two, Card.Color.Black);
            Deck deck = new Deck();

            Assert.AreNotEqual(0, card.
                CompareTo(Deck.PullRandom(deck.Cards)));
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

        [Test]
        public void ValueOfHand()
        {
            Card card1 = new Card(Card.Suit.Spades,
                Card.Rank.Two, Card.Color.Black);
            Card card2 = new Card(Card.Suit.Clubs,
                Card.Rank.Three, Card.Color.Black);
            Card card3 = new Card(Card.Suit.Hearts,
                Card.Rank.Ace, Card.Color.Red);
            Card card4 = new Card(Card.Suit.Diamonds,
                Card.Rank.Jack, Card.Color.Black);

            Game game = new Game(1);

            game.Players[0].Hand.Add(card1);
            game.Players[0].Hand.Add(card2);

            Assert.AreEqual(5, game.ValueOfHand(game.Players[0].Hand));

            game.Players[1].Hand.Add(card3);
            game.Players[1].Hand.Add(card4);

            Assert.AreEqual(21, game.ValueOfHand(game.Players[1].Hand));
        }

        [Test]
        public void SameSuit()
        {
            Card card = new Card(Card.Suit.Spades,
                Card.Rank.Two, Card.Color.Black);
            Deck deck = new Deck();

            Assert.AreEqual(0, deck.Cards[0].SameSuit(card));
        }

        [Test]
        public void ValueOfHandIfAceIsOne()
        {
            Card card1 = new Card(Card.Suit.Spades,
                Card.Rank.Eight, Card.Color.Black);
            Card card2 = new Card(Card.Suit.Clubs,
                Card.Rank.Three, Card.Color.Black);
            Card card3 = new Card(Card.Suit.Hearts,
                Card.Rank.Ace, Card.Color.Red);

            Deck deck = new Deck();

            Game game = new Game(1);

            game.Players[0].Hand.Add(card1);
            game.Players[0].Hand.Add(card2);
            game.Players[0].Hand.Add(card3);

            Assert.AreEqual(12, game.ValueOfHand(game.Players[0].Hand));
        }

        [Test]
        public void ValueOfHandIfTwoAcesIsOne()
        {
            Card card1 = new Card(Card.Suit.Spades,
                Card.Rank.Eight, Card.Color.Black);
            Card card2 = new Card(Card.Suit.Clubs,
                Card.Rank.Three, Card.Color.Black);
            Card card3 = new Card(Card.Suit.Hearts,
                Card.Rank.Ace, Card.Color.Red);
            Card card4 = new Card(Card.Suit.Diamonds,
                Card.Rank.Ace, Card.Color.Red);
            Deck deck = new Deck();

            Game game = new Game(1);

            game.Players[0].Hand.Add(card1);
            game.Players[0].Hand.Add(card2);
            game.Players[0].Hand.Add(card3);
            game.Players[0].Hand.Add(card4);

            Assert.AreEqual(13, game.ValueOfHand(game.Players[0].Hand));
        }

        [Test]
        public void ValueOfHandIfTwoMuch()
        {
            Card card1 = new Card(Card.Suit.Spades,
                Card.Rank.Eight, Card.Color.Black);
            Card card2 = new Card(Card.Suit.Clubs,
                Card.Rank.Three, Card.Color.Black);
            Card card3 = new Card(Card.Suit.Hearts,
                Card.Rank.Ace, Card.Color.Red);
            Deck deck = new Deck();

            Game game = new Game(1);

            game.Players[0].Hand.Add(card1);
            game.Players[0].Hand.Add(card2);
            game.Players[0].Hand.Add(card3);

            Assert.AreEqual(12, game.ValueOfHand(game.Players[0].Hand));
        }

        [Test]
        public void ValueOfHandIfItContainsTwoAcesWithTwoDiffValues()
        {
            Card card1 = new Card(Card.Suit.Spades,
                Card.Rank.Nine, Card.Color.Black);
            Card card3 = new Card(Card.Suit.Hearts,
                Card.Rank.Ace, Card.Color.Red);
            Card card4 = new Card(Card.Suit.Diamonds,
                Card.Rank.Ace, Card.Color.Red);
            Deck deck = new Deck();

            Game game = new Game(1);

            game.Players[0].Hand.Add(card1);
            game.Players[0].Hand.Add(card3);
            game.Players[0].Hand.Add(card4);

            Assert.AreEqual(21, game.ValueOfHand(game.Players[0].Hand));
        }

        [Test]
        public void SortingHand()
        {
            Card card1 = new Card(Card.Suit.Spades,
                Card.Rank.Nine, Card.Color.Black);
            Card card3 = new Card(Card.Suit.Hearts,
                Card.Rank.Ace, Card.Color.Red);

            Game game = new Game(1);

            game.Players[0].Hand.Add(card3);
            game.Players[0].Hand.Add(card1);

            Assert.AreEqual(0, card1.CompareTo(Deck.RankSort(game.Players[0].Hand)[0]));
        }
    }
}
