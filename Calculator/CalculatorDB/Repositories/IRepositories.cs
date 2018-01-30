using CalculatorDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDB.Repositoris
{
    public interface IRepositories<T>
    {

        //CRUD

        T Get(long Id);

        void Save(T result);

        void Delete(long Id);

        IList<T> GetByOperation(long Id);

        IList<T> GetAll();

    }
}
