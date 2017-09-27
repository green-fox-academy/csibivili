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
            input1 = input1.ToLower();
            input2 = input2.ToLower();
            char[] charArray1 = input1.ToCharArray();
            char charToRemove = ' ';
            charArray1 = charArray1.Where(val => val != charToRemove).ToArray();
            Array.Sort(charArray1);
            char[] charArray2 = input2.ToCharArray();
            charArray2 = charArray2.Where(val => val != charToRemove).ToArray();
            Array.Sort(charArray2);
            result = charArray1.SequenceEqual(charArray2);
            return result;
        }
    }
}
