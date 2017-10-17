using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF_Inheritence_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student gohan = new Student();
            Student gohanTheClone = gohan.Clone();

            Console.ReadLine();
        }
    }
}
