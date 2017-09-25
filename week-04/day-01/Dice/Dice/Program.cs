using System;

namespace Dice
{
    public class Dice
    {
        //    You have a Dice class which has 6 dice
        //    You can roll all of them with Roll()
        //    Check the current rolled numbers with GetCurrent()
        //    You can reroll with Reroll()
        //    Your task is to get where all dice is a 6

        static Random RandomValue;
        static int[] Dices = new int[6];

        public int[] Roll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 7);
            }
            return Dices;
        }

        public int[] GetCurrent()
        {
            return Dices;
        }

        public int GetCurrent(int i)
        {
            return Dices[i];
        }

        public void Reroll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 7);
            }
        }

        public void Reroll(int k)
        {
            Dices[k] = new Random().Next(1, 7);
        }

        public static void Main(string[] args)
        {
            RandomValue = new Random();
            Dice myDice = new Dice();

            myDice.Roll();

            //do
            //{
            //    foreach (var dice in myDice.GetCurrent())
            //    {
            //        Console.Write("{0} ", dice);
            //    }
            //    myDice.Reroll();
            //} while (myDice.GetCurrent() != new int[] { 6, 6, 6, 6, 6, 6 });

            for (int i = 0; i < myDice.GetCurrent().Length; i++)
            {
                while (myDice.GetCurrent(i) != 6)
                {
                    myDice.Reroll(i);
                    Console.WriteLine(myDice.GetCurrent(i));
                }
            }

            foreach (var dice in myDice.GetCurrent())
            {
                Console.Write("{0} ",dice);
            }

            Console.ReadLine();

        }
    }
}