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
            Game game = new Game(1);
            game.Deal(2);
            foreach (var card in game.Players[0].Hand)
            {
                Console.WriteLine(card.GetInfo());
            }
            Console.ReadLine();
        }
    }
}
