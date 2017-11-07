using RESTday.Excercises;
using System.Collections.Generic;

namespace RESTday.Collections
{
    public class Operations
    {
        public static readonly List<IOperation> OperationTypes = new List<IOperation>()
        {
            new Sum(),
            new Factorial(),
        };
    }
}
