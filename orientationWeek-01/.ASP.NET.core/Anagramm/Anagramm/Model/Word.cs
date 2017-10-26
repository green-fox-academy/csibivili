using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Model
{
    public class Word
    {
        public string InputWord { get; set; }

        public bool Compare(Word word1, Word word2)
        {
            return Converter(word1).Equals(Converter(word2));
        }

        public string Converter(Word word)
        {           
            return word.InputWord.OrderBy(x => x).ToString();
        }
    }
}
