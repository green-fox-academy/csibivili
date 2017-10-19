using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitors
{
    class Program
    {
        static void Main(string[] args)
        {
            var monitors = new List<Monitor>();
            monitors.FillList(monitors);

            foreach (var monitor in monitors)
            {
                monitor.Introduce();
            }

            Console.ReadLine();
        }
    }
}
