using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = from evenNumber in n
                              where evenNumber % 2 == 0
                              orderby evenNumber descending
                              select evenNumber;

            foreach (var even in evenNumbers)
            {
                Console.Write("{0} " , even);
            }

            Console.WriteLine();

            var evenNums = n.Where(x => x % 2 == 0);

            foreach (var even in evenNums)
            {
                Console.Write("{0} ", even);
            }

            Console.ReadLine();
        }
    }
}
