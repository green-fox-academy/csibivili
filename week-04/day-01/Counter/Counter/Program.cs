using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new Counter(100);

            counter.Add();
            Console.WriteLine(counter.Get());
            counter.Reset();
            
        }
    }
}
