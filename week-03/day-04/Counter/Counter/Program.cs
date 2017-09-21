using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            Console.WriteLine(CountDown(n));
            Console.ReadLine();
        }
        static int CountDown(int n)
        {
            if (n == 0)
                return 0;
            else
            return CountDown(n - 1);
        }
    }
}
