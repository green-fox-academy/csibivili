using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string!

            char[] example = { 'E', 'z', ' ', 'j', 'o', 'l', ' ', 'm', 'e', 'g', 'y', '.' };

            string sentence = new string(example);

            Console.WriteLine(sentence);

            Console.ReadLine();
        }
    }
}
