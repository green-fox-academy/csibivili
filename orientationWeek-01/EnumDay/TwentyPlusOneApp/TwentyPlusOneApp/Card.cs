﻿using System;
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

        public int CompareTo(object obj)
        {
            Card otherCard = obj as Card;
            if (otherCard != null)
            {
                return this.CardSuit.CompareTo(otherCard.CardSuit) +
                    this.CardRank.CompareTo(otherCard.CardRank) +
                    this.CardColor.CompareTo(otherCard.CardColor);
            }
            else
            {
                throw new ArgumentException("");
            }
        }

        public enum Suit
        {
            clubs,
            diamonds,
            hearts,
            spades
        }

        public enum Rank
        {
            two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7,
            eight = 8,
            nine = 9,
            ten = 10,
            Jack = 10,
            Queen = 10,
            King = 10,
            Ace = 11 // it can be 1 as well!
        }

        public enum Color
        {
            red,
            black
        }
    }
}
