using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    public class Game
    {
        static Dictionary<Card.Rank, int[]> VALUE_OF_CARDS = new Dictionary<Card.Rank, int[]>()
        {
            {Card.Rank.Two, new int[] { 2 } },
            {Card.Rank.Three, new int[] { 3 } },
            {Card.Rank.Four, new int[] { 4 } },
            {Card.Rank.Five, new int[] { 5 } },
            {Card.Rank.Six, new int[] { 6 } },
            {Card.Rank.Seven, new int[] { 7 } },
            {Card.Rank.Eight, new int[] { 8 } },
            {Card.Rank.Nine, new int[] { 9 } },
            {Card.Rank.Ten, new int[] { 10 } },
            {Card.Rank.Jack, new int[] { 10 } },
            {Card.Rank.Queen, new int[] { 10 } },
            {Card.Rank.King, new int[] { 10 } },
            {Card.Rank.Ace, new int[] { 11 , 1 } },
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



        public IEnumerable<int[]> ValueOfHand(List<Card> hand)
        {            
            var sum = hand.Select(x => ValueOfCard(x));
            return sum;
        }

        public int[] ValueOfCard(Card card)
        {
            return VALUE_OF_CARDS[card.CardRank];
        }

        public int HowManyAces(List<Card> cards)
        {
            return cards.Where(x => ValueOfCard(x)[0] == 11).Count();
        }

        public int BestResult(List<Card> hand)
        {
            // generate all the possible results and choose the best
            // these are just thoughts if it is not clear

            var possibleResults = new List<int>();
            var sum = hand.Sum(x => ValueOfCard(x)[0]);
            possibleResults.Add(sum);
            if (HowManyAces(hand) > 0)
            {
                possibleResults.Add(sum - 10);
                possibleResults.Add(sum - 20);
                possibleResults.Add(sum - 30);
            }
            
            return possibleResults.Max();
        }

        public List<string> PossibleVariations()
        {
            List<string> numbers = new List<string> { "0", "1" };
            var result =
                        (from n1 in numbers
                        from n2 in numbers
                        select n1 + n2).ToList();
            return result;
        }
    }
}
