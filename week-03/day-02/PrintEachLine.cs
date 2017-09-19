using System;
using System.IO;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"
            string[] lines = { "First", "Second line", "Third line" };
            File.WriteAllLines("my-file.txt", lines);
            try
            {
                string text = File.ReadAllText("my-file.txt");
                Console.WriteLine(text);
            }
            catch (IOException)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            
            Console.ReadLine();
        }
    }
}
