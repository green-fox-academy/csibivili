using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitors
{
    public class Monitor : Display
    {

        public Monitor(string features)
        {
            string[] tmp = features.Split(';');
            Manufacturer = tmp[0];
            Type = tmp[1];
            Size = double.Parse(tmp[2]);
            Ratio = tmp[3];
            Price = double.Parse(tmp[4]);
        }

        public static void FillList(List<Monitor> monitors)
        {
            foreach (var features in FileOperations.GetDataInLines("monitors.txt"))
            {
                monitors.Add(new Monitor(features));
            }
        }

        public string Introduce()
        {
            return String.Format("{0}", Manufacturer);
        }
    }
}
