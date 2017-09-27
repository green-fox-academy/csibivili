using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class IfAnagram
    {
        public bool IfAnagrams(string input1, string input2)
        {
            bool result;
            char[] charArray1 = input1.ToCharArray();
            Array.Sort(charArray1);
            char[] charArray2 = input2.ToCharArray();
            Array.Sort(charArray2);
            result = charArray1.SequenceEqual(charArray2);
            return result;
        }
    }
}
