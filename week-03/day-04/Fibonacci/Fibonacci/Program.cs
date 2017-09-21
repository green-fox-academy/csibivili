using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static int x = 0;
        static int y = 1;
        static int z = x + y;
        //static int which = 8;
        static List<int> list2 = new List<int>();
        static void Main(string[] args)
        {
            // The fibonacci sequence is a famous bit of mathematics, and it happens to
            // have a recursive definition. The first two values in the sequence are
            // 0 and 1 (essentially 2 base cases). Each subsequent value is the sum of the
            // previous two values, so the whole sequence is: 0, 1, 1, 2, 3, 5, 8, 13, 21
            // and so on. Define a recursive fibonacci(n) method that returns the nth
            // fibonacci number, with n=0 representing the start of the sequence.
            list2.Add(0);
            list2.Add(1);
            
            //Fibonacci(which);



            Console.WriteLine(Fibonacci(9));

            foreach (var number in list2)
            {
                Console.Write(String.Format(" {0}", number));
            }
            Console.ReadLine();
        }

        static int Fibonacci (int value)
        {
            if (value != 0)
            {               
                z = x + y;
                x = y;
                y = z;
                list2.Add(z);
                return value + Fibonacci(value - 1);
            }
            else
            {
                return y = 0;
            }         
        }
    }
}
