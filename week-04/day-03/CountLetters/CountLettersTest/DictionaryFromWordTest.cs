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
    }
}
