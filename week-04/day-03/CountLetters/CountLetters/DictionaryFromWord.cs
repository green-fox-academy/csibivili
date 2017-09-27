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
            char[] charArray = input.ToCharArray();
            char[] uniqCharArray = charArray.Distinct().ToArray();

            int[] occurance = new int[uniqCharArray.Length];

            for (int i = 0; i < occurance.Length; i++)
            {
                occurance[i] = input.Count(x => x == uniqCharArray[i]);
            }

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < uniqCharArray.Length; i++)
            {
                dictionary.Add(uniqCharArray[i], occurance[i]);
            }
            return dictionary;
        }
    }
}
