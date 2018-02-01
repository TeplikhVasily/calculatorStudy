using ConsoleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    [Authorize]
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            var calculate = new Calculate();

            var model = new CalcModel()
            {
                Operations = calculate.GetOperationNames()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Exec (string operation, string args)
        {
            var calculate = new Calculate();

            var result = calculate.Exec(operation, args.Split(new[] { ' ' , ','}));

            var model = new CalcModel()
            {
                Operations = calculate.GetOperationNames(),
                Result = result
            };

            return View("Index", model);
        }

        [HttpPost]
        public ActionResult ExecAjax(string operation, string args)
        {
            if (string.IsNullOrWhiteSpace(args))
            {
                return Content("Укажите входные данные!");
            }

            var calculate = new Calculate();

            var result = calculate.Exec(operation, args.Split(new[] { ' ', ',' }));

            return PartialView("Result", result);
        }
    }
}