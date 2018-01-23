using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    /// <summary>
    /// 
    /// </summary>

    public interface IOperation
    {
        string Name { get; }

        IOperationResult Exec(string[] args);
    }
}
