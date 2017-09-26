using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garden_app
{
    public class Plant
    {
        private static readonly string[] COLORS = new string[] { "blue", "orange", "purple", "yellow" };
        private static readonly string[] TYPE = new string[] { "Flower", "Tree" };

        private string type;
        private string color;
        private double waterAmount;
        private double waterAbsorb;

        public Plant (int type, int color, double waterAmount, double waterAbsorb)
        {
            this.type = TYPE[type];
            this.color = COLORS[color];
            this.waterAmount = waterAmount;
            this.waterAbsorb = waterAbsorb;
        }

        public Plant ()
        {

        }


    }
}
