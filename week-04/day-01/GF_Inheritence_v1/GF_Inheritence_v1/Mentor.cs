using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF_Inheritence_v1
{
    class Mentor : Person
    {
        static readonly string[] LEVEL = new string[] { "junior", "intermediate", "senior" };

        private string level = LEVEL[1];

        public Mentor (string name, int age, int gender, int level)
        {
            base.name = name;
            base.age = age;
            base.gender = GENDER[gender];
            this.level = LEVEL[level];
        }

        public Mentor ()
        {

        }

        public new void Introduce ()
        {
            Console.WriteLine("Hi, I'm {0}, {1} year old {2} {3} mentor.", name, age, gender, level);
        }

        public new void GetGoal ()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
    }
}
