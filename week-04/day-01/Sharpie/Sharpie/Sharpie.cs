using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    public class Sharpie
    {
        private string color;
        private float width;
        private float inkamount = 100;

        public Sharpie (string color, float width)
        {
            this.color = color;
            this.width = width;
        }

        public void Use()
        {
            inkamount--;
        }
    }
}
