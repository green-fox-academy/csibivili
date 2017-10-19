using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            for (int i = 0; i < 256; i++)
            {
                cars.Add(new Car());
            }

            var sameType = from car in cars
                           group car by car.Type into carType
                           select new
                           {
                               carType.Key,
                               Count = (from car in carType select car).Count()
                           };

            foreach (var car in sameType)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            var sameColor = from car in cars
                           group car by car.Color into carColor
                           select new
                           {
                               carColor.Key,
                               Count = (from car in carColor select car).Count()
                           };

            foreach (var car in sameColor)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            var MostOccuring = (from car in cars
                            group car by new { car.Type, car.Color } into mostOccuring                           
                            orderby mostOccuring.Count() descending
                            select new
                            {
                                mostOccuring.Key,
                                Count = (from car in mostOccuring select car).Count()
                            }).Take(1);

            foreach (var car in MostOccuring)
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();
        }
    }
}
