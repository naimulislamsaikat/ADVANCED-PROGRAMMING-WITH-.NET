using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zero_Hunger.Models;

namespace Zero_Hunger.Models
{
    public class ResturentRequests
    {
        public string ResturentName { get; set; }
        public string ResturentLocation { get; set; }
        public DateTime PreserveDate { get; set; }

        [Age]
        public int age { get; set; }

        public string Assigned { get; set; }
        public string Status { get; set; }
    }
}
