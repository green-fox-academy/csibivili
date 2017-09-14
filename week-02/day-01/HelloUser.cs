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
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
            string name;

            Console.Write("Please write your name here: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadLine();

        }
    }
}