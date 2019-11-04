using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using mvcunittest.Controllers;
using mvcunittest.Models;
using System.Web.Mvc;

namespace Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Details_ReturnsDetailsView()
        {
            var controller = new HomeController();
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
        }

        [Test]
        public void Details_ReturnsLaptop()
        {
            var controller = new HomeController();
            var result = controller.Details(2) as ViewResult;
            var product = (Product)result.ViewData.Model;
            Assert.AreEqual("Laptop", product.Name);

        }
    }
}
