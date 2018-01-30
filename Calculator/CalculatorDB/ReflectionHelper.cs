using CalculatorDB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDB
{

    public static class ReflectionHelper
    {
        public static string[] GetType(this Type obj)
        {

            return obj.GetType()
                .GetProperties()
                .Select(m => m.Name)
                .Except(new string[] { "Id", "TableName" })
                .ToArray();

        }


        public static string[] GetColumns(this IEntity obj)
        {

            return obj.GetType().GetColumns().ToArray();

        }

        public static string GetSerialData(this IEntity obj)
        {
            var props = obj.GetType().GetProperties();
            
            var values = new Dictionary<string, string>();

            foreach (var prop in props)
            {
                var propValue = prop.GetValue(obj);
                var str = "";

                if ( propValue == null)
                {
                    str = "NULL";
                }
                else if(propValue is string)
                {
                    str = $"N'{propValue}'";

                }
                else if (propValue is double)
                {
                    var doublValue = (double)propValue;

                    str = $"N'{propValue}'";

                }
                //Datatime
                else if (propValue is DateTime)
                {
                    var doublValue = (DateTime)propValue;

                    str = $"N'{propValue}'";

                }
                else
                {
                    str = $"N'{propValue}'";

                }

                values.Add(prop.Name, str);
            }
            //Update
            return obj.Id > 0
                ? string.Join(", ", values.Select(kv => $"[{kv.Key}] = {kv.Value}")) // С Именами
                : string.Join(", ", values.Values)

        }

    }
}
