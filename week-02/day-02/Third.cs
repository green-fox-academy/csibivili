﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `q`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print the third element of `q`

            int[] q = new int[4] { 4, 5, 6, 7 };
            printThird(q);

            Console.ReadLine();
        }

        static void printThird (int [] array)
        {
            Console.WriteLine(array[2]);
        }
    }
}