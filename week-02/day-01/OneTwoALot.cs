using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot

            Console.WriteLine("Give me a number please!");
            string userinput = Console.ReadLine();
            int number = int.Parse(userinput);

            switch (number)
            {
                case int n when (n<=0):
                    Console.WriteLine("That is not enough, my friend.");
                    break;
                case 1:
                    Console.WriteLine("That is a Big One, my friend.");
                    break;
                case 2:
                    Console.WriteLine("That is a pretty Two, my friend.");
                    break;
                default: Console.WriteLine("That is a lot, my friend.");
                    break;
            }

            Console.ReadLine();

        }
    }
}