using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garden_app
{
    public class Plant
    {
        protected static readonly string[] COLORS = new string[] { "blue", "orange", "purple", "yellow" };

        public bool needsWater;
        public string color;
        public double waterAbsorb;

        protected double waterAmount;

        public void Watering (double water)
        {
            waterAmount += waterAbsorb * water;
        }

        public string GetPlantInfo ()
        {
            string water = needsWater ? "needs some water." : "does not need any water.";
            string type = waterAbsorb == 0.75 ? "flower" : "tree";
            return String.Format("The {0} {1} {2}", color, type, water);
        }

    }
}
