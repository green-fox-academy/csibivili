using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTDD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string black = "2H 5S 9C KD AD";
            string white = "2C 3H 4S 8C AH";
            Poker.ComparePlayers(black, white);
        }
    }
}
