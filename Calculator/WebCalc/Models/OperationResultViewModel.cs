using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalc.Models
{
    public class OperationResultViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public long Id { get; set; }

        [Display(Name = "Название операции")]
        public long OperationId { get; set; }

        [Display(Name = "Значения")]
        public string Args { get; set; }

        [Display(Name = "Результат")]
        public double? Result { get; set; }

        /// <summary>
        /// Продолжительность расчета, мс
        /// </summary>

        [Display(Name = "Время выполнения")]
        public long ExecutionTime { get; set; }

        [Display(Name = "Дата выполнения")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Ошибка")]
        public string Error { get; set; }



    }
}