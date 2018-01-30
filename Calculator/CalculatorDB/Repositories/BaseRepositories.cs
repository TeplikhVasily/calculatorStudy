using CalculatorDB.Repositoris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorDB.Models;

namespace CalculatorDB.Repositories
{
    /// <summary>
    /// Сущность
    /// Храниться в БД
    /// </summary>
    public interface IEntity
    {
        long Id { get; set; }

        string TableName { get; }

        string[] Columns { get; }

        string SerialData { get; }
    }

    public class BaseRepositories<T> : IRepositories<T>
    {
        //where T: 

        public void Delete(long Id)
        {
            throw new NotImplementedException();
        }

        public T Get(long Id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<T> GetByOperation(long Id)
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
