using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebAppFreelancer.Models
{
    public class AppDbInitializer : DropCreateDatabaseAlways<WebAppFreelancerContext>  
    {
        protected override void Seed(WebAppFreelancerContext context)
        {
            /*context.countries.Add(new Country { countryid = 1, name = "Almaty" });
            context.countries.Add(new Country { countryid = 2, name = "Nur-Sultan" });
            context.countries.Add(new Country { countryid = 3, name = "Zaysan" });
            context.contacts.Add(new Contact { contactid = 1, email = "erden.aidynuly", phone = "877777777", company_name = "IITU", country = new Country { countryid = 1, name = "Oral" } });
            context.contacts.Add(new Contact { contactid = 2, email = "kazakhTeam", phone = "877777777", company_name = "SDU", country = new Country { countryid = 2, name = "Taraz" } });
            */
            base.Seed(context);
        }
    }
}