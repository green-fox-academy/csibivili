namespace RESTday.Excercises
{
    public class UntilWhat
    {
        public int Until { get; set; }

        public static int Sum(int value)
        {
            if (value > 0)
            {
                return value + Sum(value - 1);
            }
            else
            {
                return 0;
            }
        }

        public static int Factorial(int value)
        {
            if (value == 0)
                return 1;
            return value * Factorial(value - 1);
        }
    }
}


