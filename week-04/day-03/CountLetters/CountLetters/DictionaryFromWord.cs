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
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < UniqChar(input).Length; i++)
            {
                dictionary.Add(UniqChar(input)[i], Occurance(input,UniqChar(input))[i]);
            }

            return dictionary;
        }

        static char[] UniqChar (string input)
        {
            input = input.ToLower();
            char[] charArray = input.ToCharArray();
            return charArray.Distinct().ToArray();           
        }

        static int[] Occurance (string input, char[] uniqCharArray)
        {
            int[] occurance = new int[uniqCharArray.Length];
            for (int i = 0; i < occurance.Length; i++)
            {
                occurance[i] = input.ToLower().Count(x => x == uniqCharArray[i]);
            }
            return occurance;
        }
    }
}
