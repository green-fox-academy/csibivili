using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    public class Game : IRules
    {
        static Dictionary<string, int> VALUE_OF_CARDS = new Dictionary<string, int>()
        {
            {Card.Rank.Two.ToString(), 2 },
            {Card.Rank.Three.ToString(), 3 },
            {Card.Rank.Four.ToString(), 4 },
            {Card.Rank.Five.ToString(), 5 },
            {Card.Rank.Six.ToString(), 6 },
            {Card.Rank.Seven.ToString(), 7 },
            {Card.Rank.Eight.ToString(), 8 },
            {Card.Rank.Nine.ToString(), 9 },
            {Card.Rank.Ten.ToString(), 10 },
            {Card.Rank.Jack.ToString(), 10 },
            {Card.Rank.Queen.ToString(), 10 },
            {Card.Rank.King.ToString(), 10 },
            {Card.Rank.Ace.ToString(), 11 },
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
            var sum = hand.Sum(x => ValueOfCard(x));
            if (sum > 21)
            {
                foreach (var item in hand)
                {
                    if (item.CardRank == Card.Rank.Ace.ToString())
                    {
                        return sum - 10;
                    }
                }
            }
            return sum;
        }

        public int ValueOfCard(Card card)
        {
            return VALUE_OF_CARDS[card.CardRank];
        }
    }
}
