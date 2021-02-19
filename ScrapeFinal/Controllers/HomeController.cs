using ScrapeFinal.Models;
using ScrapeFinal.Models.Operation;
using ScrapeFinal.Search;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ScrapeFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(SearchParameter param) 
        {
            if (ModelState.IsValid)
            {
                //Depenedency injection can be injected  to avoid dependency here
                //For now to add new search engine add new class and initialize here
                var SearchEngines = new List<SearchEngine> { new Google(), new Bing() };
                Dictionary<string, List<int>> searchResult = new Dictionary<string, List<int>>();
                foreach (var engine in SearchEngines)
                {
                    var result = new SearchPageRanker(new SearchPageOperation()).RankURLInPages(engine, param);
                    searchResult.Add(engine.name, result);
                }
                return Json(searchResult, JsonRequestBehavior.AllowGet);
            }
            else {
                return Json(new { Success = "False", responseText = "Invalid Data" });
            }
        
        }
    }
}