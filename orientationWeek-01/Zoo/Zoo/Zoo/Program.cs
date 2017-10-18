using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mammal = new Mammal("Koala");
            Console.WriteLine(mammal.GetName() + ", " + mammal.WantChild());

            Console.ReadLine();
        }
    }
}
