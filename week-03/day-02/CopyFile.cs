using System;
using System.IO;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            Console.WriteLine(copyToFile("my-file89898.txt", "my-file_copy.txt"));
            Console.ReadLine();
        }

        static bool copyToFile (string file1, string file2)
        {
            bool successful;
            try
            {
                int counter = 0;
                string line;
                string[] lines = new string[file1.Length];
                StreamReader file = new StreamReader(file1);
                while ((line = file.ReadLine()) != null)
                {
                    lines[counter] = line;
                    counter++;
                }
                File.WriteAllLines(file2, lines);
                successful = true;
            }
            catch (Exception)
            {
                successful = false;
            }
            return successful;
        }
    }
}
