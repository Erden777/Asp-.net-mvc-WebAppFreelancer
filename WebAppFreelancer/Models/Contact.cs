using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppFreelancer.Models
{
    public class Contact
    {
        public int contactid { get; set; }
        //phone number
        public string company_name { get; set; }
        //Fk country id
        public Country country { get; set; }

        public int countryID { get; set; }


    }
}