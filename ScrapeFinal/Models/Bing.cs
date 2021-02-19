
namespace ScrapeFinal.Search
{
    public class Bing : SearchEngine

    {
        private string localUrllElement = "li class=\"b_algo\"";

        private string[] pages =
        {
               "https://infotrack-tests.infotrack.com.au/Bing/Page01.html",
                "https://infotrack-tests.infotrack.com.au/Bing/Page02.html",
                "https://infotrack-tests.infotrack.com.au/Bing/Page03.html",
                "https://infotrack-tests.infotrack.com.au/Bing/Page04.html",
                "https://infotrack-tests.infotrack.com.au/Bing/Page05.html",
                "https://infotrack-tests.infotrack.com.au/Bing/Page06.html",
                "https://infotrack-tests.infotrack.com.au/Bing/Page07.html",
                "https://infotrack-tests.infotrack.com.au/Bing/Page08.html",
                "https://infotrack-tests.infotrack.com.au/Bing/Page09.html",
                "https://infotrack-tests.infotrack.com.au/Bing/Page10.html"
        };
        public override string name { get { return "Bing"; } }
        public override string[] searchPages { get { return pages; } }
        public override string urlElement { get { return localUrllElement; } }
        
    }
}