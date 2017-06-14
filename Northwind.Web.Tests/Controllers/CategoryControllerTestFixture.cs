using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.Web.Controllers;
using System.Web.Mvc;
using Moq;
using Northwind.BusinessLayer.Interfaces;

namespace Northwind.Web.Tests.Controllers
{
    [TestClass]
    public class CategoryControllerTestFixture
    {
        private CategoryController controller;
        private Mock<ICategoryService> service;

        [TestInitialize]
        public void Setup()
        {
            service = new Mock<ICategoryService>();
            controller = new CategoryController(service.Object);
        }

        [TestMethod]
        public void Test_CategoryController_load_succesfully()
        {
            Assert.IsNotNull(controller);
        }


        [TestMethod]
        public void Test_CategoryController_Index_Method_Return_View()
        {
            var result = controller.Index() as ActionResult;

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void Test_CategoryController_Index_GetCategories()
        {
            var result = controller.Index() as ActionResult;

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestCleanup]
        public void cleanup()
        {

        }
    }
}
