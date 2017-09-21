using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 64;
            Console.WriteLine(Sum(n));
            Console.ReadLine();
        }

        static int Sum(int value)
        {
            if (value >= 0)
            {
                return value + Sum(value - 1);
            }
            else
            {
                return 0;
            }
        }
    }
}