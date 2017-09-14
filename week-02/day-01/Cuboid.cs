using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            string a, b, c;

            Console.Write("side a:");
            a = Console.ReadLine();
            Console.Write("side b:");
            b = Console.ReadLine();
            Console.Write("side c:");
            c = Console.ReadLine();

            double numa, numb, numc;
            numa = Double.Parse(a);
            numb = Double.Parse(b);
            numc = Double.Parse(c);

            Console.WriteLine("Surface Area: " + 2 * (numa * numb + numb * numc + numa * numc));
            Console.WriteLine("Volume: " + numa * numb * numc);
            Console.ReadLine();


        }
    }
}