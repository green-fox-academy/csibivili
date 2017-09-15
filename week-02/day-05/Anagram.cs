using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {

        //static string[] letters;
        static int NumberOfWords = 1;
        static string[] array;
        static int i = 0;


        static void Main(string[] args)
        {
            Greetings("Hello!");
            LetterBreakDown(array[i]);
            Console.ReadLine();
        }

        static void Greetings (string hello)
        {
            Console.WriteLine("Hello, my friend! Give me X words and I let you know if they are anagrams of each other");
            Console.WriteLine();
            Console.WriteLine("Please write here your words divided by one space: ");
            string tmp = Console.ReadLine();
            array = tmp.Split(' ');
            NumberOfWords = array.Length;
        }

        static void LetterBreakDown(string word)
        {

            char[] charArray = array[i].ToCharArray();

            /*foreach (var word in words)
            {
                Console.WriteLine(word);
            }*/

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }
        }

        static void Anagram()
        {

        }
    }
}