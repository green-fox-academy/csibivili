using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animal
    {
        private int hunger = 50;
        private int thirst = 50;

        public Animal(int hunger, int thirst)
        {
            this.hunger = hunger;
            this.thirst = thirst;
        }

        public void Eat ()
        {
            hunger--;
        }

        public void Drink ()
        {
            thirst--;
        }

        public void Play ()
        {
            hunger++;
            thirst++;
        }
    }
}
