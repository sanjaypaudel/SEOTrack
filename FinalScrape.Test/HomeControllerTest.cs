
using FinalScrape.Test.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrapeFinal.Controllers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FinalScrape.Test
{
    [TestClass]
    public class HomeControllerTest
    {
        private HomeController _controller;
        private TestDataGenerator _generator;
        public HomeControllerTest() {
            _controller = new HomeController();
            _generator = new TestDataGenerator();
        }
        [TestMethod]
        public void IndexTest()
        {
            ViewResult result = _controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void TestInvalidModel()
        {
            var validModel = _generator.GenerateEmptySearchParameter();
            // Set some properties here
            var context = new ValidationContext(validModel, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(validModel, context, results, true);
            Assert.AreEqual(false,isModelStateValid);
        }
        [TestMethod]
        public void TesValidModel()
        {
            
            var validModel = _generator.GenerateValidSearchParameter();
            // Set some properties here
            var context = new ValidationContext(validModel, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(validModel, context, results, true);
            Assert.AreEqual(true, isModelStateValid);
            // Assert here
        }
        [TestMethod]
        public void TestSearchWithError()
        {
            _controller.ModelState.AddModelError("test", "test");
            JsonResult result = _controller.Search(_generator.GenerateValidSearchParameter()) as JsonResult;
            Assert.AreEqual(result.JsonRequestBehavior, JsonRequestBehavior.DenyGet);
        }
        [TestMethod]
        public void TestValidSearch()
        {
            _controller.ModelState.Clear();
            JsonResult result = _controller.Search(_generator.GenerateValidSearchParameter()) as JsonResult;
            Assert.AreEqual(result.JsonRequestBehavior, JsonRequestBehavior.AllowGet);
        }
    }
}
