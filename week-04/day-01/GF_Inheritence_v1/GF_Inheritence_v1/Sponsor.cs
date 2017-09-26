using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF_Inheritence_v1
{
    public class Sponsor : Person
    {
        private string company = "Google";
        private int hiredStudents;

        public Sponsor (string name, int age, int gender, string company)
        {
            this.name = name;
            this.age = age;
            this.gender = GENDER[gender];
            this.company = company;
        }

        public Sponsor ()
        {

        }

        public new void Introduce ()
        {
            Console.WriteLine("Hi, I'm {0}, {1} year old {2} who represents {3} and hired {4} student(s) so far.", name, age, gender, company, hiredStudents);
        }

        public void Hire ()
        {
            hiredStudents++;
        }

        public new void GetGoal ()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
