using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            Console.WriteLine("How many girls will come to the party? ");
            string userinputGirls = Console.ReadLine();
            Console.WriteLine("How many boys will come to the party? ");
            string userinputBoys = Console.ReadLine();

            int NoOfGirls = int.Parse(userinputGirls);
            int NoOfBoys = int.Parse(userinputBoys);

            switch (NoOfGirls)
            {
                case 0:
                    Console.WriteLine("Sausage party");
                    break;
                case int n when (n > 10):
                    string result = (NoOfGirls == NoOfBoys) ? "The party is excellent!" : "Quite cool party!";
                    Console.WriteLine(result);
                    break;
                default: Console.WriteLine("Average party...");
                    break;
            }
            Console.ReadLine();
        }
    }
}