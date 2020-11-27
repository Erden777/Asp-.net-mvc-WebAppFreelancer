using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppFreelancer.Models
{
    public class Project
    {
        public int projectid { get; set; }
        public string project_name { get; set; }
        //project description
        public string description { get; set; }

        public DateTime deadline { get; set; }
        //Fk category
        public int categoryID { get; set; }

        public Category category { get; set; }
        //project price
        public double price { get; set; }
        //true or false
        public Boolean only_pro_programmers { get; set; }

    }
}