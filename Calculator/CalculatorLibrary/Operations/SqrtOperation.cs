using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorLibrary.Operations
{
    class SqrtOperation : NumberOperation
    {
        public override string Name => "sqrt";

        public override IOperationResult Exec(IEnumerable<double> args)
        {
            if (args.ElementAt(0) > 0)
            {
                var result = args.Count() >= 2
                ? Math.Pow(args.ElementAt(0), 1 / args.ElementAt(1))
                : double.NaN;

                return new OperResult(result, null);
            }
            else
            {
                var result = double.NaN;

                return new OperResult(result, "Иррациональное значение!");
            }
        }
    }
}
