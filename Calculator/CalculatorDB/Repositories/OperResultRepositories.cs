using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorDB.Models;
using System.Data.SqlClient;
using System.Globalization;

namespace CalculatorDB.Repositoris
{
    public class OperResultRepositories : IRepositories
    {


        //todo вынести в настройки
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\studynet\Calculator\CalculatorDB\AppData\CalculatorDB.mdf;Integrated Security=True";

        public void Delete(long Id)
        {
            throw new NotImplementedException();
        }

        public OperationResult Get(long Id)
        {
            throw new NotImplementedException();
        }

        public IList<OperationResult> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<OperationResult> GetByOperation(long Id)
        {
            throw new NotImplementedException();
        }

        public void Save(OperationResult result)
        {
            string queryString = "INSERT INTO [dbo].[OperationResult] ([OperationId], " +
                "[Args], [Result], [Error], [ExecutionTime], [CreationDate]) " +
                $"VALUES({result.OperationId}, N'{result.Args}', {result.Result?.ToString(CultureInfo.InvariantCulture)}, N'{result.Error}', {result.ExecutionTime}, GETDATE()); ";

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                var count = command.ExecuteNonQuery();

            }
        }
    }
}
