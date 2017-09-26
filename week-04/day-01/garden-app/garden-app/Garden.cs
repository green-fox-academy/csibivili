using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garden_app
{
    public class Garden
    {
        private List<Plant> plants = new List<Plant>();
        private string name;

        public Garden (string name)
        {
            this.name = name;
        }

        public void AddPlant (Plant plant)
        {
            plants.Add(plant);
        }

        public void Watering (int value)
        {
            double eachPlant = value / plants.Count;
            for (int i = 0; i < plants.Count; i++)
            {
                plants[i].Watering(eachPlant);
                plants[i].DontNeedWater();
            }
            Console.WriteLine("Watering with {0}",value);
        }

        public void Print ()
        {
            foreach (Plant plant in plants)
            {
                Console.WriteLine(plant.GetPlantInfo());
            }
            Console.WriteLine();
        }
    } 
}
