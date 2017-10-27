using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Model
{
    public class Player
    {
        private static readonly Dictionary<Card.Rank, int> ValuesOfCards = new Dictionary<Card.Rank, int>()
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
            return ValuesOfCards[card.CardRank];
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
