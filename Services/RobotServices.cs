using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RobotsRevisitedAgain.Models;

namespace RobotsRevisitedAgain.Services
{
    public class RobotServices
    {
        public static List<RobotModel> Builder()
        {
            using (var reader = new StreamReader(System.IO.File.Open("robots.json", FileMode.Open)))
            {
                var robotInfo = JsonConvert.DeserializeObject<List<RobotModel>>(reader.ReadToEnd());
                return robotInfo;
            }
            

        }
    }
    
}