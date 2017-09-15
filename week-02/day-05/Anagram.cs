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
        static string text = "";
        static int shortest = 3;

        static void Main(string[] args)
        {
            Greetings("Hello!");
            Input(text);
            Console.WriteLine(WordsInLetters[0].Equals(WordsInLetters[1]));
            // SHORTEST
            //Anagram(WordsInLetters);
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
            }

        }
        
        static void Anagram(List<Array> list)
        {
            bool result = false;
            for (int i = shortest; i > 1; i--)
            {
                result = WordsInLetters[i].Equals(WordsInLetters[i - 1]);
            }
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