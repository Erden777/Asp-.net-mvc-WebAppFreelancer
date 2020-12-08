using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppFreelancer.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppFreelancer.Models;

namespace WebAppFreelancer.Controllers.Tests
{
    [TestClass()]
    public class RoleViewModelsControllerTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            List<RoleViewModel> roles = new List<RoleViewModel>();
            roles.Add(new RoleViewModel("newRole", "testRole"));
            roles.Add(new RoleViewModel("newRole1", "testRole1"));
            roles.Add(new RoleViewModel("newRole2", "testRole2"));
            roles.Add(new RoleViewModel("newRole3", "testRole3"));
            if (roles == null)
            {
                Assert.IsNotNull(roles);
            }
        }
    }
}