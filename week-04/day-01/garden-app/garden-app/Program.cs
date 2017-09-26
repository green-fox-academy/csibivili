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

            var flower1 = new Flower(3);
            var flower2 = new Flower(0);
            var tree1 = new Tree (2);
            var tree2 = new Tree(1);

            garden.AddPlant(flower1);
            garden.AddPlant(flower2);
            garden.AddPlant(tree1);
            garden.AddPlant(tree2);


            garden.Print();
            garden.Watering(40);
            garden.Print();
            garden.Watering(70);
            garden.Print();

            Console.ReadLine();

        }
    }
}
