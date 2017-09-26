using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF_Inheritence_v1
{
    public class Person
    {
        protected static readonly string[] GENDER = new string[] { "female", "male" };

        protected string name = "Jane Doe";
        protected int age = 30;
        protected string gender = GENDER[0];

        public Person(string name, int age, int gender)
        {
            this.name = name;
            this.age = age;
            this.gender = GENDER[gender];
        }

        public Person()
        {

        }

        public void Introduce ()
        {
            Console.WriteLine("Hi, I'm {0}, {1} year old {2}.",name, age, gender);
        }

        public void GetGoal ()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
