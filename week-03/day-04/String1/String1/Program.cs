using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static string xy = "yyyxxxkkkkyxyx";
        static List<string> charList = new List<string>();

        static void Main(string[] args)
        {

            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.
            Console.WriteLine(ChangeXY(CharBreakDown("xy")));
            Console.ReadLine();

        }

        static List<string> CharBreakDown (string text)
        {
            var list = new List<string>();
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                charList.Add(chars[i].ToString());
            }
            return charList;
        }

        static string ChangeXY (List<string> list)
        {
            int i = 1;
            if (list[i].Equals("x") & list[i-1].Equals("y"))
            {
                list[i] = "y";
                list[i - 1] = "x";
                return list.ToString();
            }
            else
            {
                return list.ToString();
            }
        }
    }
}
