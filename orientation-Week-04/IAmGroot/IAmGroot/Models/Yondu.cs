using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAmGroot.Models
{
    public class Yondu : IComparable
    {
        public double Distance { get; set; }
        public double Time { get; set; }
        public double Speed
        {
            get { return speed; }
            set { speed = Distance / Time; }
        }

        private double speed;

        public int CompareTo(object obj)
        {
            Yondu otherYondu = obj as Yondu;
            if (otherYondu != null)
            {
                return this.CompareTo(otherYondu);
            }
            return 1;
        }
    }
}
