using System;
using System.Collections.Generic;
using System.IO;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a method that decrypts reversed-lines.txt
            FixText(IntoLines("reversed-lines.txt"));
            Console.ReadLine();
        }

        static List<string> IntoLines(string fileName)
        {
            var lines = new List<string>();
            string line;
            int i = 0;
            StreamReader reader = new StreamReader(fileName);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
                i++;
            }
            return lines;
        }

        static void FixText(List<string> lines)
        {
            foreach (var line in lines)
            {
                char[] cArray = line.ToCharArray();
                string reverse = String.Empty;
                for (int i = cArray.Length - 1; i > -1; i--)
                {
                    reverse += cArray[i];
                }
                Console.WriteLine(reverse);
            }
        }
    }
}
