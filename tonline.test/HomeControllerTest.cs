﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
