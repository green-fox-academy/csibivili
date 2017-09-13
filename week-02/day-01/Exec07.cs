using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace favoritenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string favnum;

            Console.Write("What is your favourite number? ");

            favnum = Console.ReadLine();

            Console.WriteLine("Your favourite number is " + favnum +".");

            Console.ReadLine();
        }
    }
}
