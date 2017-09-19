using System;
using System.IO;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {

            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"
            string[] lines = { "Vilmos Csibi" };
            try
            {
                File.WriteAllLines("my-file.txt", lines);
                string text = File.ReadAllText("my-file.txt");
                Console.WriteLine(text);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            
            Console.ReadLine();

        }
    }
}
