using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GF_Inheritence_v1
{
    public class Student : ICloneable   
    {

        public string Name { get; set; }
        public string Gender { get; set; }
        public string PreviousOrganization { get; set; }
        public int Age { get; set; }

        public void GetGoal()
        {
            Console.WriteLine("Be a junior developer or business analyst or devops or...");
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
