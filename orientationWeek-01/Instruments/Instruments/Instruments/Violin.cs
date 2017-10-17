using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Violin : StringedInstruments
    {
        public Violin():base(4,"Violin")
        {
        }

        public override string Sound()
        {
            return "screeche";
        }
    }
}
