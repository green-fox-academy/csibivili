using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny1
{
    class Program
    {
        static int ears = 2;
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).

            Console.WriteLine(Ears(1000));
            Console.ReadLine();

        }
        static int Ears(int number)
        {
            if (number == 1)
            {
                return ears;
            }
            else
            {
                ears = ears + 2;
                return Ears(number - 1);
            }
        }
    }
}
