using Assessment5a.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;



namespace Assessment5a.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }


        //#2 Result Action-take in 3 parameters below
        //Do calculations using 2 nums & store result in ViewBag.Result, operations in ViewBag.Operation
        public IActionResult Result(int num1, int num2, string operation)
        {
            ViewBag.Operation = operation;
           

            if (operation == "Plus")
            {
                ViewBag.result = num1 + num2;
            }
            else if (operation == "Minus")
            {
                ViewBag.result = num1 - num2;
            }
            else if (operation == "Multiply")
            {
                ViewBag.result = num1 * num2;
            }
            else if (operation == "Divide")
            {
                ViewBag.result = num1 % num2;
            }
            
            return View();
        }

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
