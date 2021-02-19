

namespace ScrapeFinal.Search
{
    public class Google : SearchEngine
    {
        private string localUrllElement = "class=\"g\"";

        private string[] pages =
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
        public override string name { get { return "Google"; } }
        public override string[] searchPages { get { return pages; } }
        public override string urlElement { get { return localUrllElement; } }
        
    }
}