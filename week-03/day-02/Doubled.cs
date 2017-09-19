using System;
using System.Collections.Generic;
using System.IO;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a method that decrypts the duplicated-chars.txt }
            Console.WriteLine(FixText(IntoChars("duplicated-chars.txt")));
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
        static string FixText(List<string> charachters)
        {
            string text = "";
            for (int i = 1; i < charachters.Count; i++)
            {
                if (charachters[i -1] != charachters[i])
                {
                    text = text + charachters[i];
                }
            }
            return text;
        }
    }
}
