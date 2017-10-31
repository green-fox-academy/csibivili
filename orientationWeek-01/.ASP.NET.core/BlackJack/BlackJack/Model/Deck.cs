using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Model
{
    public class Deck
    {
        static readonly Random RANDOM = new Random();

        public List<Card> Cards;

        public Deck()
        {
            Cards = FillDeck();
        }

        private List<Card> FillDeck()
        {
            var deck = (from suit in (Card.Suit[])Enum.GetValues(typeof(Card.Suit))
                        from rank in (Card.Rank[])Enum.GetValues(typeof(Card.Rank))
                        select new Card(suit, rank)).ToList<Card>();
            return deck;
        }

        public static Card PullRandom(List<Card> cards)
        {
            Card pulled = cards[RANDOM.Next(cards.Count())];
            cards.Remove(pulled);
            return pulled;
        }
    }
}
