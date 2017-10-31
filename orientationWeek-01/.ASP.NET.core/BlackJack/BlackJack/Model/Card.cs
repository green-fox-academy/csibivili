using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Model
{
    public class Card : IComparable
    {
        public Suit CardSuit;
        public Rank CardRank;

        public Card(Suit suit, Rank rank)        {
            CardSuit = suit;
            CardRank = rank;
        }

        public int CompareTo(object obj)
        {
            if (obj != null)
            {
                return SameSuit(obj) + SameRank(obj);
            }
            return 1;
        }

        public int SameSuit(object obj)
        {
            Card otherCard = obj as Card;
            if (otherCard != null)
            {
                return this.CardSuit.CompareTo(otherCard.CardSuit);
            }
            return 1;
        }

        public int SameRank(object obj)
        {
            Card otherCard = obj as Card;
            if (otherCard != null)
            {
                return this.CardRank.CompareTo(otherCard.CardRank);
            }
            return 1;
        }

        public string GetInfo()
        {
            return String.Format("{0}", CardRank);
        }

        public enum Suit
        {
            Spades,
            Hearts,
            Clubs,
            Diamonds,
        }

        public enum Rank
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
    }
}
