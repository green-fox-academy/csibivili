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
        //static int NumberOfWords = 1;
        static string[] array;
        //static int i = 0;
        //static List<Array> WordsInLetters = new List<Array>();
        static string word1 = "";
        static string word2 = "";

        static void Main(string[] args)
        {
            Greetings("Hello!");
            LetterBreakDown(word1);

            Console.ReadLine();
        }

        static void Greetings (string hello)
        {
            Console.WriteLine("Hello, my friend! Give me 2 words and I let you know if they are anagrams of each other");
            Console.WriteLine();
            Console.WriteLine("Please write here your words divided by one space: ");
            string tmp = Console.ReadLine();
            array = tmp.Split(' ');
            //NumberOfWords = array.Length;
            word1 = array[0];
            word2 = array[1];
        }

        static void LetterBreakDown(string word)
        {
            

            char[] charArray1 = array[0].ToCharArray();
            char[] charArray2 = array[1].ToCharArray();


            //for (int j = 0; j < array.Length; j++)
            //{
            //    WordsInLetters[j] = new int [2] { 1,2};
            //}
        }

        static void Anagram()
        {

        }
    }
}