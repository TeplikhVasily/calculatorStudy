﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDB.Models
{
    public class OperationResult : IEntity
    {
        public long Id { get; set; }

        public long OperationId { get; set; } 

        public string Args { get; set; }

        public double? Result { get; set; }

        /// <summary>
        /// Продолжительность расчета, мс
        /// </summary>

        public long ExecutionTime { get; set;  }

        public DateTime CreationDate { get; set; }

        public string Error { get; set; }
    }
}
