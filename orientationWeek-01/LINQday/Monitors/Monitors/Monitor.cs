using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitors
{
    public class Monitor : Display
    {
        private List<Monitor> monitors;

        public Monitor(string manufacturer, string type, string ratio, double price)
        {
            Manufacturer = manufacturer;
            Type = type;
            Ratio = ratio;
            Price = price;
        }

        public void FillList(string[] lines)
        {

        }
    }
}
