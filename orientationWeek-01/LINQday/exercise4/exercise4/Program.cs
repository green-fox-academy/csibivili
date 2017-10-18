using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var selectedItems = from a in n
                                where a * a > 20
                                orderby a ascending
                                select a;

            foreach (var item in selectedItems)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            var selectedNumbers = n.Where(a => a * a > 20);

            foreach (var item in selectedNumbers)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadLine();
        }
    }
}
