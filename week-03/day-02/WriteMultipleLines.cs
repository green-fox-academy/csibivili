using System;
using System.IO;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.

            //string[] lines = { "Vilmos Csibi" };
            //try
            //{
            //    File.WriteAllLines("my-file.txt", lines);
            //    string text = File.ReadAllText("my-file.txt");
            //    Console.WriteLine(text);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Unable to write file: my-file.txt");
            //}      
            toFile("my-file.txt", "alma", 10);
            Console.ReadLine();
        }

        static void toFile (string path, string word, int num)
        {
            try
            {
                string[] words = new string[num];
                for (int i = 0; i < num; i++)
                {
                    words[i] = word;
                }
                File.WriteAllLines(path, words);
                string text = File.ReadAllText(path);
                Console.WriteLine(text);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }

        }
    }
}
