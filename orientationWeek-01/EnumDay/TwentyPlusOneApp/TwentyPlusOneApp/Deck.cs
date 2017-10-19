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

        public List<Card> FillDeck()
        {
            string[] suits = EnumConverter(Enum.GetValues(typeof(Card.Suit)));
            string[] ranks = EnumConverter(Enum.GetValues(typeof(Card.Rank)));

            var deck =
                (from suit in suits
                from rank in ranks
                select new Card(rank, suit)).ToList<Card>();

            return deck;
        }

        public static List<Card> ShuffleDeck(List<Card> deck)
        {
            for (int i = deck.Count - 1; i > 0; i--)
            {
                int n = RANDOM.Next(i + 1);
                Card tmp = deck[n];
                deck[n] = deck[i];
                deck[i] = tmp;
            }
            return deck;
        }

        public string[] EnumConverter(Array array)
        {
            return array.OfType<object>().Select(o => o.ToString()).ToArray();
        }
    }
}
