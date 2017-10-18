using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA",
                "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            var aSomethingI = cities.Where(a => a.StartsWith("A") && a.EndsWith("I"));

            foreach (var item in aSomethingI)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var aStgI = from city in cities
                        where city[0] == 'A' && city[city.Length-1] == 'I'
                        select city;

            foreach (var item in aStgI)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
