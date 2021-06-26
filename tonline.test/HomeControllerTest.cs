using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace tonline.test
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            tonline.web.Controllers.HomeController homeController = new web.Controllers.HomeController();
            var result = homeController.GetList();
            Console.WriteLine("Hello Jenkins");
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Product()
        {
            tonline.web.Controllers.HomeController homeController = new web.Controllers.HomeController();
            Console.WriteLine("Hello Product 1");
            Console.WriteLine("Hello Product 2");
            Console.WriteLine("Hello Product 3");
            Console.WriteLine("Hello Product 4");
            Assert.AreEqual("1","2");
        }
    }
}
