using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greet
{
    class Program
    {
        static string al = "Greenfox"; 
        
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`
            greet(al);
            Console.ReadLine();
        }

        static void greet (string value)
        {
            Console.WriteLine("Greetings dear, " + value);
        }
    }
}