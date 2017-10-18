using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "How frequent is a character in this question?";

            var frequencyOfChars = from characters in example.ToLower()
                                   orderby characters ascending
                                   where !char.IsWhiteSpace(characters)
                                   group characters by characters into uniqChars                                   
                                   select new
                                   {
                                       uniqChars.Key,
                                       Count = (from characters in uniqChars select characters).Count()
                                   };

            foreach (var item in frequencyOfChars)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
