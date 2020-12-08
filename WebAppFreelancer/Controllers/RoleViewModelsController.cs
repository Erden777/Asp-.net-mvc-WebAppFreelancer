using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppFreelancer.Models;
using Microsoft.AspNet.Identity.Owin;

namespace WebAppFreelancer.Controllers

{


    public class RoleViewModelsController : Controller
    {
        private ApplicationRoleManager _roleManager;

        public RoleViewModelsController()
        {
        }

        public RoleViewModelsController(ApplicationRoleManager roleManager)
        {
            RoleManager = roleManager;
          
        }

        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RoleViewModels
        public async Task<ActionResult> Index()
        {
            List<RoleViewModel> roles = new List<RoleViewModel>();
            foreach(var role in RoleManager.Roles)
            {
                roles.Add(new RoleViewModel(role));
            }
            return View(roles);
        }

        // GET: RoleViewModels/Details/5
        public async Task<ActionResult> Details(string id)
        {
           var role = await RoleManager.FindByIdAsync(id);
            return View(new RoleViewModel(role));
        }


        // GET: RoleViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoleViewModels/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Name")] RoleViewModel roleViewModel)
        {
            var role = new ApplicationRole() {Name = roleViewModel.Name};
            await RoleManager.CreateAsync(role);

            return RedirectToAction("Index");
        }

        // GET: RoleViewModels/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
           
            return View(new RoleViewModel(role));
        }

        // POST: RoleViewModels/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,Name")] RoleViewModel roleViewModel)
        {
            var role = new ApplicationRole()
            {
                Id = roleViewModel.id,
                Name = roleViewModel.Name
            };
            await RoleManager.UpdateAsync(role);
             
            return View(new RoleViewModel(role));
        }

        // GET: RoleViewModels/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);

            return View(new RoleViewModel(role));
        }

        // POST: RoleViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            await RoleManager.DeleteAsync(role);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
