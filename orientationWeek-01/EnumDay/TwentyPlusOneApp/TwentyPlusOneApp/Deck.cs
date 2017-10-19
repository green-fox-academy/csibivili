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

        public List<Card> FillDeck()
        {
            string[] suits = EnumConverter(Enum.GetValues(typeof(Card.Suit)));
            string[] ranks = EnumConverter(Enum.GetValues(typeof(Card.Rank)));

            var query =
                (from suit in suits
                from rank in ranks
                select new Card(rank, suit)).ToList<Card>();

            return query;
        }

        public List<Card> ShuffleDeck(List<Card> deck)
        {
            return;
        }

        public string[] EnumConverter(Array array)
        {
            return array.OfType<object>().Select(o => o.ToString()).ToArray();
        }
    }
}
