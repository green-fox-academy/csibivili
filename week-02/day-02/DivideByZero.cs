using System;
using System.IO;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0

            int num = int.Parse(Console.ReadLine());
            try
            {
                double result = 10 / num;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                    Console.WriteLine("fail");
            }
            Console.ReadLine();
        }
    }
}
