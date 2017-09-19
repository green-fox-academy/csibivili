using System;
using System.Collections.Generic;
using System.IO;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a method that decrypts the reversed-order.txt }
            FixText(IntoLines("reversed-order.txt"));
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
            for (int i = (lines.Count - 1); i >= 0; i--)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}
