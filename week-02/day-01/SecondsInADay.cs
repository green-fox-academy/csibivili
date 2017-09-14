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
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;
            int elapsedTime = currentHours * 60 * 60 + currentMinutes * 60 + currentSeconds;
            double elapsedHours = elapsedTime / 60.00 / 60;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables

            int remainingHours = 23 - currentHours;
            int remainingMinutes = 59 - currentMinutes;
            int remainingSeconds = 59 - currentSeconds;
            int remainingTime = remainingHours * 60 * 60 + remainingMinutes * 60 + remainingSeconds;
            double remainingTimeInHours = remainingTime / 60.00 / 60;
   
            double hours = elapsedHours + remainingTimeInHours;

            Console.WriteLine(remainingTime);
            Console.WriteLine(hours);
            Console.ReadLine();

        }
    }
}