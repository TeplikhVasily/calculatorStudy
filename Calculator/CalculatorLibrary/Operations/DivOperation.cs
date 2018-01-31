using System.Collections.Generic;
using System.Linq;

namespace CalculatorLibrary.Operations
{
    public class DivOperation : NumberOperation
    {
        public override string Name => "div";

        public override IOperationResult Exec(IEnumerable<double> args)
        {

            return new OperResult(args.Aggregate((a, b) => a / b), null);

            //if (args.ElementAt(1) != 0)
            //{
            //    var result = args.Count() >= 2
            //    ? args.ElementAt(0) / args.ElementAt(1)
            //    : double.NaN;

            //    return new OperResult(result, null);
            //}
            //else
            //{
            //    var result = double.NaN;

            //    return new OperResult(result, "Знаменатель равен 0!");
            //}
        }
    }
}
