using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            int i = 0;
            int j = 0;
            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code

            // Also, print the sentence to the output with spaces in between.

            //   string tmp = list[list.FindIndex("do")];
            //   list[list.FindIndex("do")] = list[list.FindIndex("cannot")];
            //   list[list.FindIndex("cannot")] = tmp;

            /*string tmp = list[2];
            list[2] = list[5];
            list[5] = tmp;*/

            while (list[i] == "do")
            {
                i++;
            }

            while (list[j] == "cannot")
            {
                j++;
            }

            string tmp = list[i];
            list[i] = list[j];
            list[j] = tmp;

            foreach (var word in list)
            {
                Console.Write(word + " ");
            }
            Console.ReadLine();
        }
    }
}