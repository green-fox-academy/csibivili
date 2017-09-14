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
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Give me two numbers divided by commas and I let you know which one is bigger!");
            string userinput = Console.ReadLine();
            string[] usernumbers = userinput.Split(',');

            int[] numbers = new int[2];

            for (int i = 0; i < usernumbers.Length; i++)
            {
                numbers[i] = int.Parse(usernumbers[i]);
            }

            switch (numbers[0]>numbers[1])
            {
                case true:
                    Console.WriteLine("The first one is bigger.");
                    break;
                case false:
                    string second = (numbers[0] == numbers[1]) ? "They are equal." : "The second one is bigger.";
                    Console.WriteLine(second);
                    break;
                default: Console.WriteLine("Could you check your input please?");
                    break;
            }
            Console.ReadLine();
        }
    }
}