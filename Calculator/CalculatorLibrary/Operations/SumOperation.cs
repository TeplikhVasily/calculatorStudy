using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Operations
{

    public class SumOperation : NumberOperation
    {
        public override string Name => "sum";

        public override IOperationResult Exec(IEnumerable<double> args)
        {
            var result = args.Count() >= 2
                ? args.ElementAt(0) + args.ElementAt(1)
                : double.NaN;

            return new OperResult(result, null);
        }
    }
}
