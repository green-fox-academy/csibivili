using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitors
{
    public class Display
    {
        public string Manufacturer, Type, Ratio;
        public double Price, Size, Area, PricePerArea, Width, Height;

        private double diagonal;

        public Display()
        {
            Width = Size / DiagonalRatio(RatioOfSides(Ratio, Size)) * RatioOfSides(Ratio, Size)[0];
            Height = Size / DiagonalRatio(RatioOfSides(Ratio, Size)) * RatioOfSides(Ratio, Size)[1];
            Area = Width * Height;
            PricePerArea = Price / Area;
        }

        public static double[] RatioOfSides(string ratio, double size)
        {
            double[] sidesRatio = new double[2];
            string[] sides = ratio.Split(':');
            sidesRatio[0] = int.Parse(sides[0]);
            sidesRatio[1] = int.Parse(sides[1]);
            return sidesRatio;
        }

        public static double DiagonalRatio(double[] sidesRatio)
        {
            double widthRatio = sidesRatio[0];
            double heightRatio = sidesRatio[1];
            return Math.Sqrt(Math.Pow(widthRatio, 2) * Math.Pow(heightRatio, 2));
        }
    }
}
