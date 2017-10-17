using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    abstract class StringedInstruments : Instruments
    {
        protected int numberOfStrings;

        public StringedInstruments(int numberOfString, string name):base(name)
        {
            this.numberOfStrings = numberOfString;
        }

        public abstract string Sound();

        public override void Play()
        {
            Console.WriteLine("{0}, a {1}-stringed instrument that {2}s.", name, numberOfStrings, Sound());
        }

    }
}
