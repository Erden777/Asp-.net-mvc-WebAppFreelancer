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
    public class ServicesControllerTests
    {
        [TestMethod()]
        public void CreateTest()
        {
           // Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            List<Service> service = new List<Service>();
            Service s1 = new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null);
            service.Add(new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null));
            service.Add(new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null));
            service.Add(new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null));
            service.Add(new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null));
            service.Remove(s1);
            if (service.Contains(s1))
            {
                Assert.Fail();
            }
           

        }
    }
}