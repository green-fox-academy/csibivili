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
            bool output = input1 == input2;

            Assert.AreEqual(output, anagram.IfAnagrams(input1,input2));
        }

        
    }
}
