using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyOfNumbers = from a in n
                                     orderby a ascending
                                     group a by a into uniqNum
                                     select new
                                     {
                                         uniqNum.Key,
                                         Count = (from a in uniqNum select a).Count()
                                     };

            foreach (var item in frequencyOfNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var freqOfNumbers = n.GroupBy(a => a).Select(a => a.Count());

            foreach (var item in freqOfNumbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
