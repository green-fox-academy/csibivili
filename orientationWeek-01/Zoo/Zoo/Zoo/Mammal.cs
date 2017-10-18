using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Mammal : Animal
    {
        public string Fur { get; set; }

        public Mammal(string name)
        {
            base.name = name;
        }

        public override string WantChild()
        {
            return CHILD + "her uterus.";
        }

        public void BreastFeed()
        {

        }

        public override void Drink()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Greet()
        {
            throw new NotImplementedException();
        }

        public override void Shit()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }
    }
}
