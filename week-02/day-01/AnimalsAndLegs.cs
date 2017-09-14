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
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have

            string pigs, chickens;
            Console.Write("How many chickens does the farmer have? ");
            chickens = Console.ReadLine();
            int NoOfChickens = int.Parse(chickens);
            Console.Write("How many pigs does the farmer have? ");
            pigs = Console.ReadLine();
            int NoOfPigs = int.Parse(pigs);

            int legs = NoOfChickens * 2 + NoOfPigs * 4;
            Console.WriteLine("The animals have " + legs + " legs.");
            Console.ReadLine();

        }
    }
}