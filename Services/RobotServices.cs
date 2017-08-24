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
            JsonSerializer serializer = new JsonSerializer();
            var robotList = new List<RobotModel>();
            using (var reader = new StreamReader(System.IO.File.Open("robots.json", FileMode.Open)))
            {
                var robotInfo = JsonConvert.DeserializeObject<RobotModel>(reader.ReadToEnd());
                robotList.Add(robotInfo);
            }
            return robotList;

        }
    }
    
}