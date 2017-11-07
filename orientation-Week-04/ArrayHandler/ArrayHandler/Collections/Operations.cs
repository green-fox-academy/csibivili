using ArrayHandler.Models;
using System.Collections.Generic;

namespace ArrayHandler.Collections
{
    public class Operations
    {
        public static readonly List<IOperation> OperationTypes = new List<IOperation>()
        {
            new Sum(),
            new Multiply(),
            new Doubling()
        };
    }
}
