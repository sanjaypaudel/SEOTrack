using ScrapeFinal.Models;
using ScrapeFinal.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalScrape.Test.Data
{
    class TestDataGenerator
    {
        public SearchParameter GenerateValidSearchParameter() 
        {
            return new SearchParameter { SearchQuery = "online title search", SearchUrl = "infotrack.com.au" };
        }
        public SearchParameter GenerateEmptySearchParameter()
        {
            return new SearchParameter { SearchQuery = "", SearchUrl = "" };
        }
        public string GenerateInvalidURL() 
        {
            return "test";
        }
        public string GenerateValidURL()
        {
            return "https://www.google.com";
        }
        public string[] TestPages() 
        {
            return new string[]
                {
                "https://infotrack-tests.infotrack.com.au/Google/Page01.html",
                "https://infotrack-tests.infotrack.com.au/Google/Page02.html",
                "https://infotrack-tests.infotrack.com.au/Google/Page03.html",
                "https://infotrack-tests.infotrack.com.au/Google/Page04.html",
                "https://infotrack-tests.infotrack.com.au/Google/Page05.html",
                "https://infotrack-tests.infotrack.com.au/Google/Page06.html",
                "https://infotrack-tests.infotrack.com.au/Google/Page07.html",
                "https://infotrack-tests.infotrack.com.au/Google/Page08.html",
                "https://infotrack-tests.infotrack.com.au/Google/Page09.html",
                "https://infotrack-tests.infotrack.com.au/Google/Page10.html"
                };
        }
        public SearchEngine GetSearchEngine() 
        {
            return new Google();
        }
        public List<int> GetGoogleStaticTestResult() {
            return new List<int> { 1 };
        }
    }

}
