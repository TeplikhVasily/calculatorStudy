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
    public class OperationController : Controller
    {
         
        // GET: Operation
        public ActionResult Index()
        {
            var operationRepository = new BaseRepositories<Operation>();
            var dbOperations = operationRepository.GetAll();
            var operations = dbOperations.Select(o => new OperationViewModel() //Получение операций из дб с добавлением в модель
            {
                Id = o.Id,
                Name = o.Name,
                OwnerId = o.OwnerId
            });

            return View(operations);
        }
    }
}
