using CalculatorDB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDB
{
    public class Operations : IEntity 
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public long OwnerId { get; set; }


        public string TableName => "[dbo].[Operation]";

        public string[] Columns => new string[] {"Name", "OwnerId"};

        }public string SerialData => $"N'{Name}', {OwnerId}";

    }
}
