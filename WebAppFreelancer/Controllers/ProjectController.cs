using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppFreelancer.Models;

namespace WebAppFreelancer.Controllers
{
    public class ProjectController : Controller
    {
        ApplicationDbContext idb = new ApplicationDbContext();

        // GET: Project
        public ActionResult projects()
        {
            SelectList categories = new SelectList(idb.Categories, "categoryid" ,"category_name");
            ViewBag.Categories = categories;
            List<Project> projects = idb.Projects.ToList();
            ViewBag.Projects = projects;
            return View();
        }

        [HttpPost]
        public ActionResult AddProject(Project project)
        {
            if (ModelState.IsValid)
            {
                project.category = idb.Categories.Find(project.categoryID);
                idb.Projects.Add(project);
                idb.SaveChanges();
                ViewBag.c = project;
                return RedirectToAction("projects", "Project");
            }
            return RedirectToAction("index", "Home");
        }


        [Authorize]
        public ActionResult Create()
        {
            SelectList categories = new SelectList(idb.Categories, "categoryid", "category_name");
            ViewBag.Categories = categories;
            return View();
        }
    }
}