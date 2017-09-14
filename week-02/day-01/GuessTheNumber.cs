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
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int number = 8;
            int guess;

            do
            {
                string userInput = Console.ReadLine();
                int tmp = int.Parse(userInput);

                string less = (tmp < number) ? "Your number is lower." : "Your number is higher.";
                Console.WriteLine(less);
               

            } while (guess == number);
            Console.ReadLine();
        }
    }
}