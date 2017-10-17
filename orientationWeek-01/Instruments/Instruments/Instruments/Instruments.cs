using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    abstract class Instruments
    {
        protected string name;

        public Instruments(string name)
        {
            this.name = name;
        }

        public abstract void Play();
    }
}
