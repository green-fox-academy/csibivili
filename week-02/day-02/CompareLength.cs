using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareLength
{
    class Program
    {
        static int items = 0;

        static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`

            int[] p1 = new int[3] { 1, 2, 3 };
            int[] p2 = new int[2] { 4, 5 };

            counter(p1);
            counter(p2);

            string result = items > p1.Length ? "P2 has more elements." : "P2 does not have more elements.";
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void counter (Array array)
        {
            items = array.Length > items ? array.Length : items;
        }
    }
}