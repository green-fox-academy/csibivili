using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GF_Inheritence
{
    public class Student : ICloneable   
    {

        public string Name;
        public string Gender;
        public string PreviousOrganization;
        public int Age;

        public Student(string name, string gender, int age, string previousOrganization)
        {
            Name = name;
            Gender = gender;
            Age = age;
            PreviousOrganization = previousOrganization;
        }
        public void Introduce()
        {
            Console.WriteLine("{0} {1} {2} {3}",Name, Age, Gender, PreviousOrganization);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
