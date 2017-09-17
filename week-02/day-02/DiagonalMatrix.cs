using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrix
{
    class Program
    {
        static int size = 6;
        static int[,] array = new int [size,size];



        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            fill(size);
            Console.ReadLine();
        }

        static void fill (int value)
        {
            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    int zeroOrOne = i == j ? 1 : 0;
                    array[i, j] = zeroOrOne;
                    Console.Write(zeroOrOne + " ");
                }
                Console.WriteLine();
            }
        }
    }
}