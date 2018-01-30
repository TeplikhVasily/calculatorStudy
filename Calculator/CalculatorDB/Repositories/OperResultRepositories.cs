using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorDB.Models;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;

namespace CalculatorDB.Repositoris
{
    public class OperResultRepositories : IRepositories
    {


        //todo вынести в настройки
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\studynet\Calculator\CalculatorDB\AppData\CalculatorDB.mdf;Integrated Security=True";

        private IList<OperationResult> Operations;

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
            Operations = new List<OperationResult>();

            string queryString = "SELECT *";
            using (var connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);

                DataTable operations = new DataTable();

                adapter.Fill(operations);

                //Operations.Add(operations);


                //IList<string> Oper = (from r in operations.Tables["Default"].AsEnumerable()

                //   select r.Field<string>("Id") + " " +
                //   r.Field<string>("OperationId") + " " +
                //   r.Field<string>("Args") + " " +
                //   r.Field<string>("Result") + " " +
                //   r.Field<string>("ExecutionTime") + " " +
                //   r.Field<string>("CreationDate") + " " +
                //   r.Field<string>("Error")).ToList();

                return Operations;
            }
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
