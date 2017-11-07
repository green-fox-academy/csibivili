using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTday.Excercises
{
    public class Append
    {
        private string appended;

        public string Appended
        {
            get { return appended; }
            set { appended = string.Concat(value, "a"); }
        }
    }
}
