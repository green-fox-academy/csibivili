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
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.Write("How big triangle do you want? ");
            string userInput = Console.ReadLine();
            int triangleRow = int.Parse(userInput);

            for (int i = 1; i <= triangleRow; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();    
           
            }


            Console.ReadLine();
        }
    }
}