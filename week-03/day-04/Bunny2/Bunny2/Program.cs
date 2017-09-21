using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny2
{
    class Program
    {
        static int ears = 2;

        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
            Console.WriteLine(EarsCounter(5));
            Console.ReadLine();
        }

        static int EarsCounter(int lines)
        {
            if (lines == 1)
            {
                return ears;
            }
            else
            {
                if (lines % 2 == 0)
                {
                    ears = ears + 3;
                    return EarsCounter(lines - 1);
                }
                else
                {
                    ears = ears + 2;
                    return EarsCounter(lines - 1);
                }

            }
        }
    }
}
