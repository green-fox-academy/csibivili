using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Animal
    {
        public static readonly string CHILD = "wants a child from ";

        protected string name;
        protected int age;
        protected string gender;
        protected string naturalHabitat;
        protected string color;
        protected string size;

        public abstract void Greet();

        public string GetName()
        {
            return name;
        }

        public abstract string WantChild();

        public abstract void Eat();

        public abstract void Shit();

        public abstract void Drink();

        public abstract void Sleep();

    }
}
