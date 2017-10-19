using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    public class Deck
    {
        public List<Card> Cards; 

        public Deck()
        {
            Cards = FillDeck();
        }

        public List<Card> AddCard()
        {
            Card card = new Card(
                Card.Suit.spades,
                Card.Rank.Ace,
                Card.Color.black);

            List<Card> cards = new List<Card>();

            cards.Add(card);

            return cards;
        }

        public List<Card> FillDeck()
        {
            string[] suits = Enum.GetValues(typeof(Card.Suit)).
                OfType<object>().Select(o => o.ToString()).ToArray();

            string[] ranks = Enum.GetValues(typeof(Card.Rank)).
                OfType<object>().Select(o => o.ToString()).ToArray();

            var query =
                (from suit in suits
                from rank in ranks
                select new Card(rank, suit)).ToList<Card>();

            return query;
        }
    }
}
