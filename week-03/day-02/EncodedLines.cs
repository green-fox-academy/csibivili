using System;
using System.Collections.Generic;
using System.IO;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            FixText(IntoChars("encoded-lines.txt"));
            Console.ReadLine();
        }

        static List<string> IntoChars(string fileName)
        {
            var charachters = new List<string>();
            string text = File.ReadAllText(fileName);
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                charachters.Add(chars[i].ToString());
            }
            return charachters;
        }

        static void FixText(List<string> charachters)
        {

        }
    }
}
