using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!
            // Try to solve this using ElementAt() first, and optionally anything else after.

            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write(reversed[reversed.Length-1-i]); // -1 a lengthhez kapcsolodik
            }

            Console.WriteLine();

            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write(reversed.ElementAt(reversed.Length - 1 - i)); // -1 a lengthhez kapcsolodik
            }

            Console.WriteLine();

            Console.ReadLine();

        }
    }
}