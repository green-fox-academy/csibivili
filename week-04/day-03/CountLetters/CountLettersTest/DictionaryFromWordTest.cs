using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountLetters;

namespace CountLettersTest
{
    [TestFixture]
    public class DictionaryFromWordTest
    {
        DictionaryFromWord dictionary = new DictionaryFromWord();

        [Test]
        public void TestDictFromWordWhenEmptyString ()
        {
            string input = String.Empty;
            Dictionary<int,char> output = new Dictionary<int,char>();

            Assert.AreEqual(output, dictionary.DictFromWord(input));
        }

        [Test]
        public void TestDictFromWordWhenStringHasOnlyUniqLetters()
        {
            string input = "what";
            Dictionary<char, int> output = new Dictionary<char, int>();
            output.Add('w',1);
            output.Add('h',1);
            output.Add('a',1);
            output.Add('t',1);

            Assert.AreEqual(output, dictionary.DictFromWord(input));
        }

        [Test]
        public void TestDictFromWordWhenStringHasRepeatingLetters()
        {
            string input = "bomb";
            Dictionary < char, int> output = new Dictionary<char, int>();
            output.Add('b', 2);
            output.Add('o', 1);
            output.Add('m', 1);

            Assert.AreEqual(output, dictionary.DictFromWord(input));
        }

        [Test]
        public void TestDictFromWordWhenStringHasRepeatingLettersUpperLowerCase()
        {
            string input = "StevE";
            Dictionary<char, int> output = new Dictionary<char, int>();
            output.Add('s', 1);
            output.Add('t', 1);
            output.Add('e', 2);
            output.Add('v', 1);

            Assert.AreEqual(output, dictionary.DictFromWord(input));
        }
    }
}
