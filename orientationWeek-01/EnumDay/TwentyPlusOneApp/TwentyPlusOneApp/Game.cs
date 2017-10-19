using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    public class Game
    {
        public List<Card> Hand;
        public Deck Deck;

        public Game()
        {
            Deck = new Deck();
            Hand = new List<Card>();
        }

        public void Deal(int howMuch)
        {
            for (int i = 0; i < howMuch; i++)
            {
                Hand.Add(Deck.PullRandom(Deck));
            }
        }

        public int ValueOfCards(List<Card> cards)
        {
            return 0;
        }
    }
}
