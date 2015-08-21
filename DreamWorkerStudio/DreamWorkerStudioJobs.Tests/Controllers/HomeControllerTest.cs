using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DreamWorkerStudioJobs;
using DreamWorkerStudioJobs.Controllers;
using DreamWorkerStudioJobs.Models;

namespace DreamWorkerStudioJobs.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.",result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            var mvc = new MvcApplication();
            ApplyForJobResult result = new ApplyForJobResult();
            int a = 0;
            foreach(var item in result.GetType().GetProperties())
            {
                try
                {
                item.SetValue(result,Convert.ChangeType(a,item.PropertyType));

                }
                catch(Exception)
                {

                }
                a++;
            }
            MvcApplication.Save(result);
        }
    }
}
