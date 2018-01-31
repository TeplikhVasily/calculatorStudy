using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorDB.Models;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;

namespace CalculatorDB.Repositories
{
    public class OperResultRepositories : BaseRepositories<OperationResult>
    {
        public IList<OperationResult> GetByOperation(long Id)
        {
            return null;
        }
    }
}
