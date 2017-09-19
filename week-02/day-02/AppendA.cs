using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendA
{
    class Program
    {
        static string am;

        static void Main(string[] args)
        {
            // - Create a string variable named `am` and assign the value `kuty` to it
            // - Write a function called `appendA` that gets a string as an input
            //   and appends an 'a' character to its end
            // - Print the result of `appendA(am)`

            am = "kuty";

            appendA(am);
            Console.ReadLine();
        }

        static void appendA (string value)
        {
            //string appendAA = value + "a";
            StringBuilder appendAA = new StringBuilder(value + "a");
            Console.WriteLine(appendAA);
        }
    }
}