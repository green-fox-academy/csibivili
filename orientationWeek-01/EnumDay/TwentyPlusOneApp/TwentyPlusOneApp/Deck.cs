using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
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
            var deck = (from color in (Card.Color[])Enum.GetValues(typeof(Card.Color))
                        from suit in (Card.Suit[])Enum.GetValues(typeof(Card.Suit))
                        from rank in (Card.Rank[])Enum.GetValues(typeof(Card.Rank))
                        select new Card(suit, rank, color)).ToList<Card>();

            return deck;
        }

        public static List<Card> ShuffleDeck(List<Card> cards)
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int n = RANDOM.Next(i + 1);
                Card tmp = cards[n];
                cards[n] = cards[i];
                cards[i] = tmp;
            }
            return cards;
        }

        public static List<Card> RankSort(List<Card> cards)
        {
            return (from card in cards
                    orderby card.CardRank
                    select card).ToList();
        }

        public static Card PullFirst(List<Card> cards)
        {
            Card pulled = cards[0];
            cards.Remove(pulled);
            return pulled;
        }

        public static Card PullLast(List<Card> cards)
        {
            Card pulled = cards[cards.Count() - 1];
            cards.Remove(pulled);
            return pulled;
        }

        public static Card PullRandom(List<Card> cards)
        {
            Card pulled = cards[RANDOM.Next(cards.Count())];
            cards.Remove(pulled);
            return pulled;
        }
    }
}
