using CalculatorDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDB.Repositories
{
    public interface IUserRepository
    {
        User GetByLogin(string login);

        bool Check(string login, string password);


    }
}
