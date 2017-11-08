namespace RESTday.Excercises
{
    public interface IOperation
    {
        string WhatKindOfEvent { get; set; }
        int Result { get; set; }
    }

    public class Sum : IOperation
    {
        private int result;

        public string WhatKindOfEvent { get; set; } = "sum";
        public int Result
        {
            get { return result; }
            set { result = UntilWhat.Sum(value); }
        }
    }

    public class Factorial : IOperation
    {
        private int result;

        public string WhatKindOfEvent { get; set; } = "factor";
        public int Result
        {
            get { return result; }
            set { result = UntilWhat.Factorial(value); }
        }
    }
}
