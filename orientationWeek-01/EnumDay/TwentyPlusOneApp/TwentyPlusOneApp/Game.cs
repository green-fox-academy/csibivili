using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    public class Game
    {
        public List<Player> Players;
        public Deck Cards;

        public Game(int numberOfEnemies)
        {
            Cards = new Deck();
            Players = new List<Player>();
            Players.Add(new User());
            for (int i = 0; i < numberOfEnemies; i++)
            {
                Players.Add(new Enemy());
            }
        }

        public void Deal(Game game, int howMuch)
        {
            for (int j = 0; j < game.Players.Count(); j++)
            {
                for (int i = 0; i < howMuch; i++)
                {
                    Players[j].Hand.Add(Deck.PullRandom(Cards));
                }
            }
        }
    }
}
