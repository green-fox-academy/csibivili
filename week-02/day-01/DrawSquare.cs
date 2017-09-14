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
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was

            string userInput = Console.ReadLine();
            int size = int.Parse(userInput);

            for (int i = 0; i < size; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("%");
                    }
                }
                
                if ((i > 0) & (i <size - 1))
                {
                    Console.Write("%");
                    for (int j = 0; j < (size - 2); j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("%");
                }

                if (i == size - 1)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("%");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}