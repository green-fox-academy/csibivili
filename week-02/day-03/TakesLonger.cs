using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            // StringBuilder sb1 = new StringBuilder(quote.Insert(21,"always takes longer than"));

            StringBuilder sb1 = new StringBuilder(quote.Insert(quote.IndexOf("y",0), "always takes longer than "));

            Console.WriteLine(quote);
            Console.WriteLine(sb1);
            Console.ReadLine();
        }
    }
}