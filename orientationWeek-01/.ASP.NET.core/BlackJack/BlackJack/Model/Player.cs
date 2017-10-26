using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Model
{
    public class Player
    {
        public List<Card> Hand;

        public Player()
        {
            Hand = new List<Card>();
        }

        public void Deal(Deck deck)
        {
            for (int i = 0; i < 2; i++)
            {
                Hand.Add(Deck.PullRandom(deck.Cards));
            }
        }            

        public void Pull(Deck deck)
        {
            this.Hand.Add(Deck.PullRandom(deck.Cards));
        }
    }
}
