using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourth")
            // ...
            printer("It ", "was ", "fun.");
            Console.ReadLine();
        }

        static void printer (params string [] strings)
        {
            foreach (var str in strings)
            {
                Console.Write(str);
            }
        }
    }
}