using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RobotsRevisitedAgain.Models;
using RobotsRevisitedAgain.Services;

namespace RobotsRevisitedAgain.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var robotList = RobotServices.Builder();
            return View(robotList);
        }
        [Route("user/{Id}")]
        public IActionResult UserID(int Id)
        {
            var robotList = RobotServices.Builder();
            return View(robotList[Id-1]);
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
