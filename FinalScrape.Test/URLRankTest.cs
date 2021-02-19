using FinalScrape.Test.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrapeFinal.Models.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalScrape.Test
{
    [TestClass]
    public class URLRankTest
    {
        private SearchPageOperation _searchOperation;
        private TestDataGenerator _generator;
        public URLRankTest() 
        {
            _searchOperation = new SearchPageOperation();
            _generator = new TestDataGenerator();
        }
        [TestMethod]
        public void NullParameterSearchTest() 
        {
            var result = _searchOperation.ExtractUrlRank(null, null);
            CollectionAssert.AreEqual(result,new List<int>());
        }
        [TestMethod]
        public void ValidParamSearchTest()
        {
            var result = _searchOperation.ExtractUrlRank(_generator.GetSearchEngine(), _generator.GenerateValidSearchParameter());
            Assert.AreNotEqual(0, result.Count);
        }
        [TestMethod]
        public void ValidParamSearchDetailTest()
        {
            var result = _searchOperation.ExtractUrlRank(_generator.GetSearchEngine(), _generator.GenerateValidSearchParameter());
            CollectionAssert.AreEquivalent(_generator.GetGoogleStaticTestResult(), result);
        }
    }
}
