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
            double a = 24;
            int out1 = 0;
            // if w is even increment out by one
            if (a % 2 == 0)
            {
                out1 = out1 + 1;
            }


            Console.WriteLine(out1);

            int b = 13;
            string out2 = "";
            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "More!",
            // if more than 20 set out2 to "Less!"

            switch (b)
            {
                case int n when (n >= 10 & n <= 20):
                    out2 = "Sweet!";
                    break;
                case int n when (n < 10):
                    out2 = "More!";
                    break;
                case int n when (n > 20):
                    out2 = "Less!";
                    break;
                default:
                    break;
            }

            Console.WriteLine(out2);

            int c = 123;
            int credits = 100;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same

            if (isBonus == false)
            {
                c = (credits >= 50) ? c - 2 : c - 1;
            }

            Console.WriteLine(c);

            int d = 8;
            int time = 120;
            string out3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"

            if (d % 4 == 0)
            {
                out3 = (time <= 200) ? "check" : "Time out";
            }
            else
            {
                out3 = "Run Forest Run!";
            }

            Console.WriteLine(out3);
            Console.ReadLine();
        }
    }
}