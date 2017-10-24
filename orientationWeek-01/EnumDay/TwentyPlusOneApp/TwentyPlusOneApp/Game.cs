using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    public class Game
    {
        static Dictionary<Card.Rank, int> VALUE_OF_CARDS = new Dictionary<Card.Rank, int>()
        {
            {Card.Rank.Two, 2 },
            {Card.Rank.Three, 3 },
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
            {Card.Rank.Ace, 1 },
        };

        public List<Player> Players;
        public Deck Cards;

        public Game(int numberOfOpponents)
        {
            Cards = new Deck();
            Players = new List<Player>();
            Players.Add(new User());
            for (int i = 0; i < numberOfOpponents; i++)
            {
                Players.Add(new Opponent());
            }
        }

        public void Deal(int howMuch)
        {
            for (int j = 0; j < Players.Count(); j++)
            {
                for (int i = 0; i < howMuch; i++)
                {
                    Players[j].Hand.Add(Deck.PullRandom(Cards.Cards));
                }
                Players[j].Points = ValueOfHand(Players[j].Hand);
            }
        }

        public List<Player> RankPlayers()
        {
            return Players.OrderByDescending(x => x.Points)
                .ThenBy(x => x.Hand.Count())
                .Where(x => x.Points <= 21).ToList();
        }

        public void CountPoints(Player player)
        {
            player.Points = ValueOfHand(player.Hand);
        } 

        public int ValueOfHand(List<Card> hand)
        {
            if (HowManyAces(hand) > 0 && ValueOfCards(hand) + 10 <= 21)
            {
                return ValueOfCards(hand) + 10;
            }
            else
            {
                return ValueOfCards(hand);
            }
        }

        public int ValueOfCard(Card card)
        {
            return VALUE_OF_CARDS[card.CardRank];
        }

        public int HowManyAces(List<Card> cards)
        {
            return cards.Where(x => 
                x.CardRank == Card.Rank.Ace).Count();
        }

        public int ValueOfCards(List<Card> hand)
        {
            return hand.Sum(x => ValueOfCard(x));
        }
    }
}
