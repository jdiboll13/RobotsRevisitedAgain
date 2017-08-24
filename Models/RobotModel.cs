using System;
using System.Collections.Generic;

namespace RobotsRevisitedAgain.Models
{
    public class RobotModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string University { get; set; }
        public string Job { get; set; }
        public string Company { get; set; }
        public List<string> Skills { get; set; }
        public string Phone { get; set; }
        public Dictionary<string, string> Address { get; set; }

    }
}