using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Dominoes
    {
        
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            var listOfNumberPairs = new List<string>();
            var finailList = new List<string>();

            for (int i = 0; i < dominoes.Count; i++)
            {
                listOfNumberPairs.Add("[" + dominoes[i].GetValues()[0].ToString() + ", " + dominoes[i].GetValues()[1].ToString() + "]");
            }

            finailList.Add(listOfNumberPairs[0]);

            int j = 0;

            for (int i = j; i < listOfNumberPairs.Count; i++)
            {
                if (listOfNumberPairs[j][4] == listOfNumberPairs[i][1])
                {
                    finailList.Add(listOfNumberPairs[i]);
                    j = i;
                    i = 0;
                }
            }
         
            foreach (var domino in finailList)
            {
                Console.Write(domino);
            }

            Console.ReadLine();
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}