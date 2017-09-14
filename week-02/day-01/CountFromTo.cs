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
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Give me two integers divided by commas please");
            string userinput = Console.ReadLine();
            string[] usernumbers = userinput.Split(',');
            int[] numbers = new int[2];

            for (int i = 0; i < usernumbers.Length; i++)
            {
                numbers[i] = int.Parse(usernumbers[i]);
            }

            if (numbers[1] <= numbers[0])
            {
                Console.WriteLine("The second number should be bigger.");
            }
            else
            {
                for (int i = numbers[0]; i < numbers[1]; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}