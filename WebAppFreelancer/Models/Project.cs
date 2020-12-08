using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppFreelancer.Models
{
    public class Project
    {   

        public int projectid { get; set; }

        [Required(ErrorMessage = "The field must be set")]
        public string project_name { get; set; }
      

        [Required(ErrorMessage = "The field must be set")]
        public string description { get; set; }

        [Required(ErrorMessage = "The field must be set")]
        public DateTime deadline { get; set; }

        //Fk category
        public int categoryID { get; set; }

        public Category category { get; set; }
        //project price

        [Required]
        public double price { get; set; }
        //true or false
        public Boolean only_pro_programmers { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var res = new List<ValidationResult>();
            if (string.IsNullOrWhiteSpace(this.project_name))
            {
                res.Add(new ValidationResult("Project name not entered"));
            }if(this.price<0 || this.price > 1000000000)
            {
                res.Add(new ValidationResult("Price is not correct"));
            }
            return res;
        }
    }

   
}