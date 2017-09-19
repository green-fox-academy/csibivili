using System;
using System.IO;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            Console.WriteLine(fileName("my-files.txt"));
            Console.ReadLine();

        }

        static string fileName(string value)
        {
            //string path = Path.GetFullPath(value);
            //return path;
            int lineCount = 0;
            try
            {
                using (var reader = File.OpenText(value))
                {
                    while (reader.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }
            }
            catch (IOException)
            {
                Console.Write("");
            }
            
            string lines = lineCount.ToString();
            return lines;
        }
    }
}
