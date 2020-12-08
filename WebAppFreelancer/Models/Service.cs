using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppFreelancer.Models
{
    public class Service
    {
        public Service() { }
      
        public Service(int v1, string v2, DateTime now, int v3, string v4, string v5, string v6, ApplicationUser p)
        {
            this.serviceid = v1;
            this.serviceName = v2;
            this.createdDate = now;
            this.price = v3;
            this.duration = v4;
            this.level = v5;
            this.userID = v6;
            this.user = p;
        }

        public int serviceid { get; set; }
        public string serviceName { get; set; }
        public DateTime createdDate { get; set; }
        public int price { get; set; }
        public string duration { get; set; }
        public string level { get; set; }
        public string userID { get; set; }
        public ApplicationUser user { get; set; }
       
    }
}