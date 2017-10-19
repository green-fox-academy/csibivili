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
        public Deck deck;

        public Game()
        {
            deck = new Deck();
        }

        public void Deal(int howMuch)
        {
            for (int i = 0; i < howMuch; i++)
            {
                Hand.Add(Deck.PullRandom(deck));
            }
        }
    }
}
