using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    public class Game : IRules
    {
        static Dictionary<Card.Rank, int> VALUE_OF_CARDS = new Dictionary<Card.Rank, int>()
        {
            {Card.Rank.Two, 2 },
            {Card.Rank.Three , 3 },
            {Card.Rank.Four, 4 },
            {Card.Rank.Five, 5 },
            {Card.Rank.Six, 6 },
            {Card.Rank.Seven, 7 },
            {Card.Rank.Eight, 8 },
            {Card.Rank.Nine, 9 },
            {Card.Rank.Ten, 10 },
            {Card.Rank.Jack, 10 },
            {Card.Rank.Queen, 10 },
            {Card.Rank.King, 10 },
            {Card.Rank.Ace, 11 },
        };

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
                    Players[j].Hand.Add(Deck.PullRandom(Cards.Cards));
                }
            }
        }

        public int ValueOfHand(List<Card> hand)
        {
            return 0;
        }
    }
}
