using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalc.Controllers
{
    public class MyController : Controller
    {
        [HttpGet]
        public ActionResult Index(long id)
        {
            ViewData.Model = id.ToString();
            return View("Name"); // если строка передается то явно указывается модель
        }

        [HttpPost]
        public ActionResult Index(string firstname)
        {

            
            ViewData["age"] = 25;
            ViewData.Add("isAdmin", false);
            ViewBag.LastName = "Теплых";

            ViewBag.cities = new string[] { "Москва", "Киров" };


            return View("Name", model: firstname); // если строка передается то явно указывается модель
        }


    }
}