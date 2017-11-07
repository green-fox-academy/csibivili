using System.Linq;

namespace ArrayHandler.Models
{
    public class OperationOnNumbers
    {
        public string What { get; set; }
        public int[] Numbers { get; set; }

        public static int Sum(int[] numbers)
        {
            return numbers.Sum();
        }

        public static int Multiply(int[] numbers)
        {
            int multiplied = 1;
            foreach (var number in numbers)
            {
                multiplied *= number;
            }
            return multiplied;
        }

        public static int[] Double(int[] numbers)
        {
            int[] doubled = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                doubled[i] = numbers[i] * 2;
            }
            return doubled;
        }
    }
}
