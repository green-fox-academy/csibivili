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
            if (HowManyAces(hand) > 0)
            {
                return BestResult(hand);
            }
            var sum = hand.Sum(x => ValueOfCard(x));
            return sum;
        }

        public int ValueOfCard(Card card)
        {
            return VALUE_OF_CARDS[card.CardRank];
        }

        public int HowManyAces(List<Card> cards)
        {
            return cards.Where(x => ValueOfCard(x) == 11).Count();
        }

        public int BestResult(List<Card> hand)
        {
            // generate all the possible results and choose the best
            // these are just thoughts if it is not clear

            var possibleResults = new List<int>();
            var sum = hand.Sum(x => ValueOfCard(x));
            possibleResults.Add(sum);
            if (HowManyAces(hand) > 0)
            {
                possibleResults.Add(sum - 10);
                possibleResults.Add(sum - 20);
                possibleResults.Add(sum - 30);
            }
            
            return possibleResults.Max();
        }
    }
}
