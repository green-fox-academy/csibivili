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

            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card.GetInfo());
            }

            Console.WriteLine();

            foreach (var card in Deck.ShuffleDeck(deck.Cards))
            {
                Console.WriteLine(card.GetInfo());
            }

            Console.ReadLine();
        }
    }
}
