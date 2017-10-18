using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var averageOfNumbers = (from a in n
                                   select a).Average();

            Console.WriteLine(averageOfNumbers);

            var averageOfNums = n.Average();

            Console.WriteLine(averageOfNums);

            Console.ReadLine();
        }
    }
}
