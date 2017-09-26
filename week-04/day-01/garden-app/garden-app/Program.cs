using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garden_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var garden = new Garden("kertecske");

            var flower1 = new Plant(0, 3, 4, 0.75);
            var flower2 = new Plant(0, 0, 4, 0.75);
            var tree1 = new Plant(1, 2, 4, 0.4);
            var tree2 = new Plant(1, 1, 4, 0.4);

            garden.AddPlant(flower1);
            garden.AddPlant(flower2);
            garden.AddPlant(tree1);
            garden.AddPlant(tree2);
        }
    }
}
