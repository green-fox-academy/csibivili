using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static List<int> numbers = new List<int> ();

        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter
            greet();
            sum(numbers);
            Console.ReadLine();
        }

        static void greet ()
        {
            Console.WriteLine("Please write here your numbers which would you like to sum divided by commas!");
            string tmp = Console.ReadLine();
            string[]  numbersInText = tmp.Split(',');
            for (int i = 0; i < numbersInText.Length; i++)
            {
                numbers.Add(int.Parse(numbersInText[i]));
            }
        }

        static void sum (List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}