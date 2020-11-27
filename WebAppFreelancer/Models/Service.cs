using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppFreelancer.Models
{
    public class Service
    {   
        public int serviceid { get; set; }
        public string serviceName { get; set; }
        public int price { get; set; }
        public string duration { get; set; }
        public string level { get; set; }
        public string userID { get; set; }
        public ApplicationUser user { get; set; }
       
    }
}