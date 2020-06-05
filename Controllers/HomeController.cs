using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidations.Models;

namespace DojoSurveyValidations.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var model = new Survey();
            return View(model);
        }

        public IActionResult Process(Survey Surv)
        {
            if(ModelState.IsValid)
            {
                return View("Result", Surv);
            }
            return View("Index", Surv);
        }

        // public IActionResult Result(Survey Surv)
        // {
        //     Console.WriteLine($"\n\n{Surv}\n\n");
        //     Console.WriteLine($"\n{Surv.Language}\n");
        //     return View(Surv);
        // }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
