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
    public class UserRepository : BaseRepositories<User> , IUserRepository
    {
        public bool Check(string loginOrEmail, string password)
        {
            //Проверка юзера на наличие в базе

            var result = ExecQuery($"[Password] = N'{password}' AND" +
                "[Status] in (1, 4) AND" +
                $"([Login] = N'{loginOrEmail}' OR [Email] = N'{loginOrEmail}')");

            return result.Any();
        }

        public User GetByLogin(string login)
        {
            throw new NotImplementedException();
        }

        public IList<OperationResult> GetByOperation(long Id)
        {
            return null;
        }
    }
}
