using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF_Inheritence_v1
{
    public class Student : Person
    {
        private string previousOrganization = "The School of Life";
        private int skippedDays;

        public Student(string name, int age, int gender, string previousOrganization)
        {
            base.name = name;
            base.age = age;
            base.gender = GENDER[gender];
            this.previousOrganization = previousOrganization;
        }

        public Student ()
        {

        }

        public new void GetGoal()
        {
            Console.WriteLine("Be a junior developer or business analyst or devops or...");
        }

        public new void Introduce ()
        {
            Console.WriteLine("Hi, I'm {0}, {1} age old {2} from {3} who skipped {4} day(s) from the course already.",name,age,gender,previousOrganization,skippedDays);
        }

        public void SkipDays (int value)
        {
            skippedDays += value;
        }
    }


}
