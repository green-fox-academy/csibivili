using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            Card card = new Card(Card.Suit.spades, Card.Rank.Ace, Card.Color.black);

            Console.WriteLine(deck.Cards[0].CompareTo(card));

            Console.ReadLine();
        }
    }
}
