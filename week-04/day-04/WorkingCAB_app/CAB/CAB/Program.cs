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
            int input = 0;//int.Parse(Console.ReadLine());

            //while (cowsAndBulls.CAB(input).Equals("cowcowcowcow")) ;
            //{
            //    Console.WriteLine(cowsAndBulls.CAB(input));
            //    input = int.Parse(Console.ReadLine());
            //}

            do
            {
                input = int.Parse(Console.ReadLine());
                Console.WriteLine(cowsAndBulls.CAB(input));
            } while (!cowsAndBulls.CAB(input).Equals("cowcowcowcow"));
    
            Console.WriteLine(cowsAndBulls.CAB(input));

            Console.ReadLine();
        }
    }
}
