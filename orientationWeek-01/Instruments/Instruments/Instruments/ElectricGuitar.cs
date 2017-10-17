using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class ElectricGuitar : StringedInstruments
    {
        public ElectricGuitar():base(6,"Electric Guitar")
        {
        }

        public ElectricGuitar(int numberOfStrings):base(numberOfStrings,"Electric Guitar")
        {
            base.numberOfStrings = numberOfStrings;
        }

        public override string Sound()
        {
            return "twang";
        }
    }
}
