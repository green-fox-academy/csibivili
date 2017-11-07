namespace ArrayHandler.Models
{
    public interface IOperation
    {
        string WhatOperation { get; set; }
        object Result { get; set; }
    }

    public class Sum : IOperation
    {
        private int sum;

        public string WhatOperation { get; set; } = "sum";
        public object Result
        {
            get { return sum; }
            set { sum = OperationOnNumbers.Sum((int[])value); }
        }
    }

    public class Multiply : IOperation
    {
        private int multiplied;

        public string WhatOperation { get; set; } = "multiply";
        public object Result
        {
            get { return multiplied; }
            set { multiplied = OperationOnNumbers.Multiply((int[])value); }
        }
    }

    public class Doubling : IOperation
    {
        private int[] doubled;

        public string WhatOperation { get; set; } = "double";
        public object Result
        {
            get { return doubled; }
            set { doubled = OperationOnNumbers.Double((int[])value); }
        }
    }

}
