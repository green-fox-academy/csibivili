using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!

            string example = "Let's find the UPpeRcASe LeTTErs!";

            var uppercaseLetters = from charachter in example
                                   where char.GetUnicodeCategory(charachter) == UnicodeCategory.UppercaseLetter
                                   select charachter;

            foreach (var item in uppercaseLetters)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            var upperLetters = example.Where(a => char.GetUnicodeCategory(a) == UnicodeCategory.UppercaseLetter);

            foreach (var item in upperLetters)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }
    }
}
