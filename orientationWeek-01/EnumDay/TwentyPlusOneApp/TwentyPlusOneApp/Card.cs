using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{ 
    public class Card : IComparable
    {
        public string CardSuit, CardRank, CardColor;

        public Card(Suit suit, Rank rank, Color color)
        {
            CardSuit = suit.ToString();
            CardRank = rank.ToString();
            CardColor = color.ToString();
        }

        public Card(string rank, string suit, string color)
        {
            CardRank = rank;
            CardSuit = suit;
            CardColor = color;
        }

        public int CompareTo(object obj)
        {
            if (obj != null)
            {
                return  SameSuit(obj) + SameColor(obj) + SameRank(obj);
            }
            else
            {
                throw new ArgumentException("Are you sure that is a card?");
            }
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

        public int SameColor(object obj)
        {
            Card otherCard = obj as Card;
            if (otherCard != null)
            {
                return this.CardColor.CompareTo(otherCard.CardColor);
            }
            return 1;
        }

        public string GetInfo()
        {
            return String.Format("{0} of {1}", CardRank, CardSuit);
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

        public enum Color
        {
            black,
            red
        }
    }
}
