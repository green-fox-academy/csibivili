using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Car
    {
        static readonly Random RANDOM = new Random();

        public string Type, Color;

        public Car()
        {
            Type = RandomType();
            Color = RandomColor();
        }

        public enum CarType
        {
            Skoda,
            VW,
            Seat,
            Porsche,
            Audi,
            Lada,
            BMW,
            Dacia
        }

        public enum CarColor
        {
            green,
            red,
            white,
            black,
            blue,
            yellow,
            purple,
            pink
        }

        public string RandomColor()
        {
            Array colorValues = Enum.GetValues(typeof(CarColor));
            return RandomEnum(colorValues);
        }

        public string RandomType()
        {
            Array typeValues = Enum.GetValues(typeof(CarType));
            return RandomEnum(typeValues);
        }

        public string RandomEnum(Array array)
        {
            return array.GetValue(RANDOM.Next(array.Length)).ToString();
        }
    }

    
}
