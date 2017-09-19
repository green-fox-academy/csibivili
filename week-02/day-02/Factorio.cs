using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            int number = int.Parse(Console.ReadLine());
            factorio(number);
            Console.ReadLine();
        }

        static void factorio (int value)
        {
            int factorial = 1;
            for (int i = value; i > 0; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}