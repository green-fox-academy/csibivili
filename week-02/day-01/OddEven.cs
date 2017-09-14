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
            // Than prints "Odd" if the number is odd, or "Even" it it is even.

            string userinput;

            Console.WriteLine("Give me a number and I let you know if it is even or odd.");
            userinput = Console.ReadLine();
            int number = int.Parse(userinput);

            string result = (number % 2 == 0) ? "even" : "odd";

            Console.WriteLine("The number is " + result + ".");
            Console.ReadLine();

        }
    }
}