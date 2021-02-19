using FinalScrape.Test.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrapeFinal.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalScrape.Test
{
    [TestClass]
   public  class UtilityTest
    {
        private TestDataGenerator _generator;
        public UtilityTest() 
        {
            _generator = new TestDataGenerator();
        }
        [TestMethod]
        public void ValidHTMLPageLoaderTest() 
        {
            var result = HTMLLoader.LoadUrl(_generator.GenerateValidURL());
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void InValidHTMLPageLoaderTest()
        {
            var result = HTMLLoader.LoadUrl(_generator.GenerateInvalidURL());
            Assert.IsNull(result);
        }
    }
}
