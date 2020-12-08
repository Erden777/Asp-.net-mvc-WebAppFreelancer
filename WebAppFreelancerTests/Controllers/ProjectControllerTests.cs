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
    public class ProjectControllerTests
    {
        [TestMethod()]
        public void projectsTest()
        {
            List<Service> project = new List<Service>();
            Service s1 = new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null);
            project.Add(new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null));
            project.Add(new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null));
            project.Add(new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null));
            project.Add(new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null));
            if (project == null) { Assert.Fail(); }
            
        }   
    }
}