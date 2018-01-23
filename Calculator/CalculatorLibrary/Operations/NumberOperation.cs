using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Operations
{
    public abstract class NumberOperation : IOperation
    {
        public virtual string Name => "";

        public IOperationResult Exec(string[] args)
        {
            var numbers = args.Select(it => Convert.ToDouble(it));

            return Exec(numbers);
        }

        public abstract IOperationResult Exec(IEnumerable<double> args);
    }
}
