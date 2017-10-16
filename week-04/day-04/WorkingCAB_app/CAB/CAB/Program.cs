using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CAB
{
    class Program
    {
        static void Main(string[] args)
        {
            CowsAndBulls cowsAndBulls = new CowsAndBulls();

            cowsAndBulls.RandomNumber();
            int input = 0;

            Console.WriteLine("Can you find out the number? If you think so please write a 4 digit number.");

            do
            {
                bool ifNumber = int.TryParse(Console.ReadLine(),out input);
                if (ifNumber)
                {
                    if (1000 <= input && input <=9999)
                    {
                        Console.WriteLine(cowsAndBulls.NotMatch(input));
                    }
                    else
                    {
                        Console.WriteLine("This number is out of range. You lost!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("This is not a number. You lost!");
                    break;
                }
            } while (!cowsAndBulls.NotMatch(input).Equals("CowCowCowCow"));
            Console.WriteLine("YOU WON!!!");
            Console.ReadLine();
        }
    }
}
