using CalculatorDB.Models;
using CalculatorDB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    public class OperationResultController : Controller
    {
        // GET: OperationResult
        public ActionResult Index()
        {
            var operationRepository = new BaseRepositories<OperationResult>();
            var dbOperations = operationRepository.GetAll();
            var operationResults = dbOperations.Select(o => new OperationResultViewModel() //Получение операций из дб с добавлением в модель
            {
                Id = o.Id,
                OperationId = o.OperationId,
                Args = o.Args,
                Result = o.Result,
                ExecutionTime = o.ExecutionTime,
                CreationDate = o.CreationDate,
                Error = o.Error
            });

            return View(operationResults);
        }
    }
}