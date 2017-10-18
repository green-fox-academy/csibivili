using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise10
{
    public class IAnimal
    {
        static readonly Random random = new Random();

        public string Color, Type, Name;

        public string Introduce()
        {
            return String.Format("{0} is a {1} {2}", Name, Color, Type);
        }

        public static string RandomName(string[] name)
        {
            int rand = random.Next(name.Length);
            return name[rand];
        }

        public static string RandomType(string[] type)
        {
            int rand = random.Next(type.Length);
            return type[rand];
        }

        public static string RandomColor(string[] colors)
        {
            int rand = random.Next(colors.Length);
            return colors[rand];
        }
    }
}
