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
        static char[] chars = new char[5] { 'm', 'i', 'v', 'a', 'n' };


        static void Main(string[] args)
        {
            //Greetings("Hello!");
            //string temp = new string(chars);
            //Console.WriteLine(temp);
            //Input(text);
            //bool fuck = (string.Join("", WordsInLetters[0]) == string.Join("", WordsInLetters[1]));
            //Console.WriteLine(fuck);
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
                /*foreach (var letters in WordsInLetters[i])
                {
                    Console.WriteLine(letters);
                }*/
                //string temp = new string(WordsInLetters[i]);
            }

        }
        
        static void Anagram(List<Array> list)
        {
            bool result = false;
            for (int i = 0; i < (WordsInLetters.Count - 1); i++)
            {

                //string temp = new string (WordsInLetters[i]);
                //result = (string.Join("", WordsInLetters[i]) == string.Join("", WordsInLetters[i+1]));
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