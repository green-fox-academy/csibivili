using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;

namespace AnagramTest
{
    [TestFixture]
    public class IfAnagramTest
    {
        IfAnagram anagram = new IfAnagram();
        [Test]
        public void TestIfAnagramWhenEmptyStrings ()
        {
            string input = String.Empty;
            string output = String.Empty;

            Assert.AreEqual(output, anagram.IfAnagrams(input));
        }
    }
}
