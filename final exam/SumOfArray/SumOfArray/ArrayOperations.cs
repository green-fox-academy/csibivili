using System.Collections.Generic;

namespace SumOfArray
{
    public class ArrayOperations
    {
        public static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static float Average(int[] array)
        {
            float avg = 0;

            try
            {
                return avg = Sum(array) / array.Length;
            }
            catch (System.Exception)
            {
                return 0;
            }           
        }

        public static List<int> EvenNumbers(int[] array)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 ==0)
                {
                    evenNumbers.Add(array[i]);
                }
            }
            return evenNumbers;
        }

        public static float AverageOfEvenNumbers(int[] array)
        {
            List<int> evenNumbers = EvenNumbers(array);

            float result = 0;

            for (int i = 0; i < evenNumbers.Count; i++)
            {
                result += evenNumbers[i];
            }

            return result / evenNumbers.Count;
        }
    }
}
