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
            Cards = AddCard();
        }

        public List<Card> AddCard()
        {
            Card card = new Card(
                Card.Suit.spades, 
                Card.Rank.Ace, 
                Card.Color.black);

            List<Card> cards = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                cards.Add(card);
            }

            return cards;
        }

        public void FillDeck()
        {
        }

    }
}
