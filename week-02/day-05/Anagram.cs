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
        static List<Array> WordsInLetters = new List<Array>();
        //static List<string> OrderedLetters = new List<string>();
        static string text = "";
        static int shortest = 3;
        //static char[] chars = new char[5] { 'm', 'i', 'v', 'a', 'n' };


        static void Main(string[] args)
        {
            Greetings("Hello!");
            Input(text);
            //bool fuck = (string.Join("", WordsInLetters[0]) == string.Join("", WordsInLetters[1]));
            //Console.WriteLine(fuck);
            // SHORTEST
            Anagram(WordsInLetters);
            Console.ReadLine();
        }

        static void Greetings (string hello)
        {
            Console.WriteLine("Hello, my friend! Give me X words and I let you know if they are anagrams of each other");
            Console.WriteLine();
            Console.WriteLine("Please write here your words divided by one space: ");
            text = Console.ReadLine();

        }

        static void Input(string word)
        {
            array = text.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                WordsInLetters.Add(array[i].ToCharArray());
                Array.Sort(WordsInLetters[i]);
<<<<<<< HEAD
                char[] charArray = WordsInLetters[i];
                string word = new string(WordsInLetters[i]);
=======
                string word = new string(WordsInLetters[i]);

                //char[] charArray = WordsInLetters[i];


                /*for (int j = 0; j < array[j].Length; j++)
                {
                    string tmp = new string(charArray[j]);
                }*/


>>>>>>> 1e03948b80886fe6330484b41670fad13164364c
            }

        }
        
        static void Anagram(List<Array> list)
        {
            /*bool result = false;
            for (int i = 0; i < WordsInLetters.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result = Array.  (WordsInLetters[j], j) == Array.IndexOf(WordsInLetters[j + 1], j) ? true : false;
                }
            }*/


            /*bool result = false;
            for (int i = 0; i < (WordsInLetters.Count - 1); i++)
            {

                //string word1 = new string(WordsInLetters[i], 0, CharArray.Count());
                //result = word1 == word2 ? true : false;
            }*/
            Console.WriteLine(result);
           
        }

        /*
        static void shortest (string value)
        {
            for (int i = 0; i < length; i++)
            {

            }
        }
        */


    }
}