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
        //static List<char> datalist1 = new List<char>();
        //static List<char> datalist2 = new List<char>();
        //static List<string> List1 = new List<string>();
        //static List<string> List2 = new List<string>();
        static int shorter = 0;

        static void Main(string[] args)
        {
            Greetings("Hello!");
            //LetterBreakDown(word1);
            //LetterBreakDown(word2);
            //Anagram(charArray1, charArray2);
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
            charArray1 = array[0].ToCharArray();
            Array.Sort(charArray1);
            word2 = array[1];
            charArray2 = array[1].ToCharArray();
            Array.Sort(charArray2);
            shorter = (word1.Length <= word2.Length) ? word1.Length : word2.Length;
            bool result = false;
            for (int i = 0; i < shorter; i++)
            {
                result = !(charArray1[i] == charArray2[i]) ? false : true;
            }
            Console.WriteLine(result);

        }
        /*
        static void LetterBreakDown(string word)
        {
            if (word == word1)
            {
                
                Array.Sort(charArray1);
            }
            else
            {
                charArray2 = array[i].ToCharArray();
                Array.Sort(charArray2);
            }


        }

        static void Anagram(char [] array1, char [] array2)
        {
            bool result = false;
            for (int i = 0; i < shorter; i++)
            {
                result = !(array1[i] == array2[i]) ? false : true;
            }
            Console.WriteLine(result);
            foreach (var letters in array1)
            {
                Console.WriteLine(letters);
            }
            foreach (var letters in array2)
            {
                Console.WriteLine(letters);
            }
        }*/
       
    }
}