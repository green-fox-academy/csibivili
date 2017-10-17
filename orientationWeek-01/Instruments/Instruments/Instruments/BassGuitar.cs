using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class BassGuitar : StringedInstruments
    {
        public BassGuitar():base(4,"Bass Guitar")
        {
        }

        public BassGuitar(int numberOfStrings):base(numberOfStrings,"Bass Guitar")
        {
            base.numberOfStrings = numberOfStrings;
        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }
}
