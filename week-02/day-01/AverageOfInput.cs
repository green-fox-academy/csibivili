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
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            string[] userinput = new string[5];
            string tmp;

            Console.WriteLine("Give me 5 integers divided by commas and I let you know the sum and average of those numbers!");
            tmp = Console.ReadLine();
            userinput = tmp.Split(',');

            int[] numbers = new int[5];

            for (int i = 0; i < userinput.Length; i++)
            {
                numbers[i] = int.Parse(userinput[i]);
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            int average = sum / 5;

            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The average is " + average);
            /*foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }*/
            Console.ReadLine();
        }
    }
}