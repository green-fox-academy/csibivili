using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garden_app
{
    public class Flower : Plant
    {
        public Flower (int color)
        {
            base.color = COLORS[color];
            base.waterAmount = waterAmount;
            waterAbsorb = 0.75;
            NeedsWater();
        }

        public void NeedsWater ()
        {
            if (waterAmount < 5)
            {
                needsWater = true;
            }
        }
    }
}
