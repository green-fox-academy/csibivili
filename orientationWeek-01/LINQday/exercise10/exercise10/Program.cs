using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var foxes = new List<Fox>();

            for (int i = 0; i < 100; i++)
            {
                foxes.Add(new Fox());
            }

            var greenPallida = from fox in foxes
                               where fox.Color == "green" && fox.Type == "pallida"
                               select fox;

            foreach (var fox in greenPallida)
            {
                Console.WriteLine(fox.Introduce());
            }

            Console.ReadLine();
        }
    }
}
