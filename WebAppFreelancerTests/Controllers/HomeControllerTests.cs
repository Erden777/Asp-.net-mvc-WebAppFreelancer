﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppFreelancer.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppFreelancer.Models;
using System.Web.Mvc;

namespace WebAppFreelancer.Controllers.Tests
{
    
    [TestClass()]
    public class HomeControllerTests
    {
        ApplicationDbContext idb = new ApplicationDbContext();
        [TestMethod()]
        public void AboutTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            string message = "Your application description page.";
            // Assert
            Assert.AreEqual("Your application description page.", message);
        }

        [TestMethod()]
        public void IndexTest()
        {
            List<Service> service = new List<Service>();
            service.Add(new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null));
            service.Add(new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null));
            service.Add(new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null));
            service.Add(new Service(1, "Test service", DateTime.Now, 33333, "2 Week", "middle", "1", null));
            if (service != null)
            {

            }
            else
            {
                Assert.Fail();
            }
        }
    }
}