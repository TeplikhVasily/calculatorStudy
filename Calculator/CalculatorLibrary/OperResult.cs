using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    class OperResult : IOperationResult
    {

        public OperResult(double result, string error)
        {
            Result = result;
            Error = error;
        }

        public double Result { get; set; }
        public string Error { get; set; }
    }
}
