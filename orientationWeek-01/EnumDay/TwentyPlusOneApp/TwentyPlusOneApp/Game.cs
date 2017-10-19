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
        public Deck Cards;

        public Game()
        {
            Cards = new Deck();
            Hand = new List<Card>();
        }

        public void Deal(int howMuch)
        {
            for (int i = 0; i < howMuch; i++)
            {
                Hand.Add(Deck.PullRandom(Cards));
            }
        }

        public int ValueOfCards(List<Card> cards)
        {
            return 0;
        }
    }
}
