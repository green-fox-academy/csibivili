using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double avgdailycodin = 6;
            double semesterweeks = 17;
            double avgweeklyworkinghours = 52;
            double totalhours , percentage;
            // double percentage;

            totalhours = 5 * semesterweeks * avgdailycodin;

            percentage = (totalhours / (avgweeklyworkinghours * semesterweeks)) * 100;
          
            Console.WriteLine(totalhours);

            Console.WriteLine(percentage);

            Console.ReadLine();
        }
    }
}
