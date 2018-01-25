using CalculatorDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDB.Repositoris
{
    public interface IRepositories
    {

        //CRUD

        OperationResult Get(long Id);

        void Save(OperationResult result);

        void Delete(long Id);

        IList<OperationResult> GetByOperation(long Id);

        IList<OperationResult> GetAll();

    }
}
