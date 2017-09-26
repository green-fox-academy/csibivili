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

            var flower1 = new Flower(0, 4);
            var flower2 = new Flower(1, 4);
            var tree1 = new Tree (2,4);
            var tree2 = new Tree(3,4);

            garden.AddPlant(flower1);
            garden.AddPlant(flower2);
            garden.AddPlant(tree1);
            garden.AddPlant(tree2);

            flower2.Watering(10.5);


        }
    }
}
