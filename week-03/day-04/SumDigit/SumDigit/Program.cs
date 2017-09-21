using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigit
{
    class Program
    {
        static int counter = 1;

        static void Main(string[] args)
        {

            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

            Console.WriteLine(NumberOfDigits(1111));
            Console.ReadLine();
                
        }

        static int NumberOfDigits (int value)
        {
            if (value / 10 > 0)
            {
                counter++;
                return NumberOfDigits(value / 10);               
            }
            else
            {
                return counter;
            }
        }
    }
}
