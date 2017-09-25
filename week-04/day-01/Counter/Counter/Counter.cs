using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class Counter
    {
        private int value = 0;
        private int initialvalue = 0;

        public Counter (int value)
        {
            this.value = value;
            initialvalue = value;
        }

        public Counter ()
        {

        }

        public void Add ()
        {
            this.value++;
        }

        public string Get ()
        {
            return this.value.ToString();
        }

        public void Reset ()
        {
            this.value = initialvalue;
        }
    }
}
