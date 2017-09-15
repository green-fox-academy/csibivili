using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {

        static string[] array;
        static int i = 0;
        //static List<Array> WordsInLetters = new List<Array>();
        static string word1 = "";
        static string word2 = "";
        static char[] charArray1, charArray2;
        static List<string> List1 = new List<string>();
        static List<string> List2 = new List<string>();

        static void Main(string[] args)
        {
            Greetings("Hello!");
            LetterBreakDown(word1);
            LetterBreakDown(word2);
            CreateList(charArray1);
            CreateList(charArray2);
            Console.ReadLine();
        }

        static void Greetings (string hello)
        {
            Console.WriteLine("Hello, my friend! Give me 2 words and I let you know if they are anagrams of each other");
            Console.WriteLine();
            Console.WriteLine("Please write here your words divided by one space: ");
            string tmp = Console.ReadLine();
            array = tmp.Split(' ');
            word1 = array[0];
            word2 = array[1];
        }

        static void LetterBreakDown(string word)
        {
            if (word == word1)
            {
                charArray1 = array[i].ToCharArray();
            }
            else
            {
                charArray2 = array[i].ToCharArray();
            }


            //char[] charArray1 = array[i].ToCharArray();
            //char[] charArray2 = array[i].ToCharArray();

            //for (int j = 0; j < array.Length; j++)
            //{
            //    WordsInLetters[j] = new int [2] { 1,2};
            //}
        }

        static void CreateList(char [] temp)
        {
            if (temp == charArray1)
            {
                for (int i = 0; i < charArray1.Length; i++)
                {
                    List1[i] = charArray1[i].ToString();
                }
            }
            else
            {
                for (int i = 0; i < charArray1.Length; i++)
                {
                    List2[i] = charArray2[i].ToString();
                }
            }
        }
        static void Anagram(List<string> lists)
        {

        }
    }
}