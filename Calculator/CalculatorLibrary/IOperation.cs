﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    /// <summary>
    /// 
    /// </summary>

    public interface IOperation
    {
        string Name { get; }

        /// <summary>
        /// Выполнить операцию с входными значениями
        /// </summary>
        /// <param name="args">Входные параметры</param>
        /// <returns>Результат операции</returns>

        IOperationResult Exec(string[] args);

    }
}
