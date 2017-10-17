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
            var person = new Person();
            var goku = new Mentor("Goku", 25, 1, 2);
            var mentor = new Mentor();
            var gohan = new Student("Gohan",6,1,"Earth");
            Student gohanTheClone = gohan.Clone();
            var student = new Student();
            var satan = new Sponsor("Piccolo", 5000, 1, "Namek");
            var sponsor = new Sponsor();

            person.Introduce();
            gohan.SkipDays(3);
            gohan.Introduce();
            gohanTheClone.Introduce();
            goku.Introduce();
            mentor.Introduce();
            satan.Hire();
            satan.Introduce();
            sponsor.Introduce();

            var pallida = new PallidaClass("DragonBall");

            pallida.AddStudent(gohan);
            pallida.AddStudent(student);
            pallida.AddMentor(goku);
            pallida.AddMentor(mentor);
            pallida.Info();

            Console.ReadLine();
        }
    }
}
