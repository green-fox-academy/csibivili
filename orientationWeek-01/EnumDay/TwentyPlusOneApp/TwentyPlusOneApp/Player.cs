using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    public class Player
    {
        public List<Card> Hand;
        public int Points;

        public Player()
        {
            Hand = new List<Card>();
            Points = 0;
        }

        public void Pull(Deck deck)
        {
            this.Hand.Add(Deck.PullRandom(deck.Cards));
        }
    }
}
