using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppFreelancer.Models;
using System.Data.Entity;
using WebAppFreelancer.CustomFilters;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace WebAppFreelancer.Controllers
{
    public class HomeController : Controller
    {
       // WebAppFreelancerContext db = new WebAppFreelancerContext();

        ApplicationDbContext idb = new ApplicationDbContext();



        public ActionResult Index()
        {
            IList<string> roles = new List<string> { "Роль не определена" };
            ApplicationUserManager userManager = HttpContext.GetOwinContext()
                                           .GetUserManager<ApplicationUserManager>();
            ApplicationUser user = userManager.FindByEmail(User.Identity.Name);
            if (user != null)
                roles = userManager.GetRoles(user.Id);
            ViewBag.Users = idb.Users.ToList();
            IEnumerable<Contact> contacts = idb.contacts;
            IEnumerable<Country> countries = idb.countries;
            List<Contact> Lcontacts =contacts.ToList();
            ViewBag.Countries = countries.ToList();
            List<Service> service = idb.Services.ToList();
            List<Category> categories = idb.Categories.ToList();
            ViewBag.Projects = idb.Projects.ToList();
            ViewBag.Services = service;
            ViewBag.Contacts = Lcontacts;
            ViewBag.Role = roles;

            return View();
        }

       

        public ActionResult AutocompleteSearch(string term)
        {
            List<ApplicationUser> users = idb.Users.ToList();
            var models = users.Where(a => a.name.Contains(term))
                            .Select(a => new { value = a.name })
                            .Distinct();
            return Json(models, JsonRequestBehavior.AllowGet);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            return View();
        }
       

        [HttpGet]
        [AuthLog(Roles = "Admin")]
        public ActionResult Admin()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Country()
        {
            IEnumerable<Country> countries = idb.countries;
            List<Country> Lcountries = countries.ToList();
            ViewBag.Countries = Lcountries;
            return View();
        }

        [HttpGet]
        public ActionResult Category()
        { 
            List<Category> Lcategories = idb.Categories.ToList();
            ViewBag.Categories = Lcategories;
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            idb.Categories.Add(category);
            idb.SaveChanges();

            return RedirectToAction("Category");
        }

        [HttpPost]
        public ActionResult AddCountry(Country country)
        {
            idb.countries.Add(country);
            idb.SaveChanges();

            return RedirectToAction("Country");
        }

        [HttpPost]
        public ActionResult updateCountry(Country country)
        {
            idb.Entry(country).State = EntityState.Modified;

            idb.SaveChanges();
           
            ViewBag.c = country;
            return RedirectToAction("Country");
           // return View();
        }

        

        [HttpPost]
        public ActionResult updateCategory(Category category)
        {
            idb.Entry(category).State = EntityState.Modified;

            idb.SaveChanges();
            ViewBag.c = category;
            return RedirectToAction("Category");
            // return View();
        }

        [HttpPost]
        public ActionResult DeleteCategory(Category category)
        {
           idb.Entry(category).State = EntityState.Deleted;
           idb.SaveChanges();

            return RedirectToAction("Category");
           
        }

        public JsonResult Find(int id)
        {
            var country = idb.countries.Find(id);
            return  Json(country, JsonRequestBehavior.AllowGet);
        }
        public JsonResult FindCategory(int id)
        {
            var category = idb.Categories.Find(id);
            return Json(category, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details(int id)
        {
            Country c = idb.countries.FirstOrDefault(com => com.countryid == id);
            if (c != null)
                return PartialView(c);
            return HttpNotFound();
        }


        public ActionResult Contact(int id)
        {
            ViewBag.Message = "Your contact page.";
            IEnumerable<Country> countries = idb.countries;
            List<Country> Lcountries = countries.ToList();
            foreach(var b in Lcountries){
                if(b.countryid == id)
                {
                    ViewBag.C = b;
                }
            }
            if (ViewBag.C == null)
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" }); ;
            }
            return View();
        }
    }
}