using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squaredValues = from s in n
                                select s * s;

            foreach (var value in squaredValues)
            {
                Console.Write("{0} ",value);
            }

            Console.WriteLine();

            var sqrValues = n.Select(x => x * x);

            foreach (var value in sqrValues)
            {
                Console.Write("{0} ", value);
            }

            Console.ReadLine();
        }
    }
}
