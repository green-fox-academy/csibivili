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
        public double waterAmount;

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

        public void DontNeedWater ()
        {
            if (waterAbsorb == 0.75 & waterAmount >= 5)
            {
                needsWater = false;
            }
            if (waterAbsorb == 0.4 & waterAmount >= 10)
            {
                needsWater = false;
            }
        }
    }
}
