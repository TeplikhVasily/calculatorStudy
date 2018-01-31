using CalculatorDB.Models;
using System.Collections.Generic;

namespace CalculatorDB.Repositoris
{
    public interface IRepositories<T>
        where T : IEntity
    {

        //CRUD

        T Get(long Id);

        void Save(T result);

        void Delete(long Id);

        IList<T> GetAll();

    }
}
