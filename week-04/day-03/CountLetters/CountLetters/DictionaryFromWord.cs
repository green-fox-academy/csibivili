using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    public class DictionaryFromWord
    {
        public Dictionary<char,int> DictFromWord(string input)
        {
            char[] charArray1 = input.ToCharArray();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < charArray1.Length; i++)
            {
                dictionary.Add(charArray1[i], 1);
            }
            return dictionary;
        }
    }
}
