using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppFreelancer.Models
{
    public class Models
    {
    }
    public class ServiceModel
    {
        [Display(Name ="Service name")]
        [Required(ErrorMessage ="Service name required")]
        public string serviceName { get; set; }

        [Required(ErrorMessage = "Created date required")]
        [Display(Name = "Date")]
        public DateTime createdDate { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Service price required")]
        public int price { get; set; }

        [Display(Name = "Duration")]
        [Required(ErrorMessage = "Service duration required")]
        public string duration { get; set; }

        [Display(Name = "Level")]
        [Required(ErrorMessage = "service name required")]
        public string level { get; set; }
    }

    public class CountryModel
    {
        [Display(Name = "Country Name")]
        [Required(ErrorMessage = "Country Name required")]
        public string name { get; set; }

        [Display(Name = "Country code")]
        [Required(ErrorMessage = "Country code required")]
        public string code { get; set; }
    }
}