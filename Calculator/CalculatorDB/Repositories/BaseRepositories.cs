﻿using CalculatorDB.Repositoris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorDB.Models;
using System.Data.SqlClient;

namespace CalculatorDB.Repositories
{
    /// <summary>
    /// Базовый репозиторий
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepositories<T> : IRepositories<T>
        where T : IEntity
    {
        public BaseRepositories()
        {
            enityType = typeof(T);
        }

        public void Delete(long Id)
        {
            throw new NotImplementedException();
        }

        public T Get(long id)
        {
            var items = ExecQuery($"[Id] = {id}");
            return items.FirstOrDefault();
        }

        public IList<T> GetAll()
        {
            return ExecQuery();
        }

        public void Save(T entity)
        {
            var queryString = "";

            if (entity.Id > 0)
            {
                queryString =
                $"UPDATE {enityType.GetTableName()} SET {entity.GetSerialData()} WHERE Id = { entity.Id }";
            }
            else
            {
                var columnStr = string.Join("], [", entity.GetColumns());

                queryString =
                $"INSERT INTO {enityType.GetTableName()} ([{columnStr}]) VALUES({entity.GetSerialData()})";
            }

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        #region Private Members

        protected IList<T> ExecQuery(string condition = "")
        {
            var result = new List<T>();

            var columnStr = string.Join("], [", enityType.GetColumns());

            var queryString = $"SELECT [Id], [{columnStr}] FROM {enityType.GetTableName()}";

            if (!string.IsNullOrWhiteSpace(condition))
            {
                queryString += $" WHERE {condition}";
            }

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        var entity = reader.GetObject<T>();
                        result.Add(entity);
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return result;
        }

        protected Type enityType { get; set; }

        // todo - вынести в настройки
        protected string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\studynet\Calculator\CalculatorDB\AppData\CalculatorDB.mdf;Integrated Security=True";

        #endregion
    }
}