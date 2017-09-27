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
            string input1 = String.Empty;
            string input2 = String.Empty;
            bool output = true;

            Assert.AreEqual(output, anagram.IfAnagrams(input1,input2));
        }

        [Test]
        public void TestIfAnagramWhenSameWords ()
        {
            string input1 = "same";
            string input2 = "same";
            bool output = true;

            Assert.AreEqual(output, anagram.IfAnagrams(input1, input2));
        }

        [Test]
        public void TestIfAnagramWhenNotAnagrams ()
        {
            string input1 = "same";
            string input2 = "other";
            bool output = false;

            Assert.AreEqual(output, anagram.IfAnagrams(input1, input2));
        }

        [Test]
        public void TestIfAnagramWhenAnagrams ()
        {
            string input1 = "rail safety";
            string input2 = "fairy tales";
            bool output = true;

            Assert.AreEqual(output, anagram.IfAnagrams(input1, input2));
        }
        
    }
}
