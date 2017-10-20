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
            string[] suits = EnumConverter(Enum.GetValues(typeof(Card.Suit)));
            string[] ranks = EnumConverter(Enum.GetValues(typeof(Card.Rank)));
            string[] colors = EnumConverter(Enum.GetValues(typeof(Card.Color)));

            var deck = (from color in colors
                        from suit in suits
                        from rank in ranks
                        select new Card(rank, suit, color)).ToList<Card>();

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

        public string[] EnumConverter(Array array)
        {
            return array.OfType<object>().Select(o => o.ToString()).ToArray();
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
