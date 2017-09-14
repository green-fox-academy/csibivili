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
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            Console.Write("How big diamond do you want? ");
            string userInput = Console.ReadLine();
            int triangleRow = int.Parse(userInput);


            for (int i = 0; i <= triangleRow; i = i + 2)
            {
                for (int k = (triangleRow/2); k > (i / 2); k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            for (int i = (triangleRow - 2); i >= 0; i = i -2)
            {
                for (int k = (i / 2 + 1); (k * 2) <= triangleRow; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}