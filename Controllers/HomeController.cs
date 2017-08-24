using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RobotsRevisitedAgain.Models;

namespace RobotsRevisitedAgain.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var reader = new StreamReader(System.IO.File.Open("robots.json", FileMode.Open)))
            using (var jsonReader = new JsonTextReader(reader))
            {
                while (true)
                {
                    
                }
            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
