using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF_Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Student gohan = new Student("Gohan","male",6,"Earth");
            Student gohanTheClone = (Student)gohan.Clone();

            gohan.Introduce();
            gohanTheClone.Introduce();

            Console.ReadLine();
        }
    }
}
