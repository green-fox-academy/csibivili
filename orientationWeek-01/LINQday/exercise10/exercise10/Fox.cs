using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise10
{
    public class Fox : IAnimal
    {
        static readonly string[] COLOR = { "red", "white", "black", "green", "grey" };
        static readonly string[] TYPE = { "pallida", "culpeo", "artic", "bengal", "corsac" };
        static readonly string[] NAME = { "Jesus", "Morpheus", "Yoda", "Gandalf", "Dumbledore" };

        public Fox()
        {
            Name = RandomName(NAME);
            Type = RandomType(TYPE);
            Color = RandomColor(COLOR);
        }

    }
}
