using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF_Inheritence_v1
{
    class PallidaClass
    {
        private string className;
        private List<Student> students = new List<Student>();
        private List<Mentor> mentors = new List<Mentor>();

        public PallidaClass (string className)
        {
            this.className = className;
        }

        public void AddStudent (Student student)
        {
            students.Add(new Student());
        }

        public void AddMentor (Mentor mentor)
        {
            mentors.Add(new Mentor());
        }

        public void Info ()
        {
            Console.WriteLine("Pallida {0} class has {1} students and {2} mentors.", className, students.Count, mentors.Count);
        }
    }
}
