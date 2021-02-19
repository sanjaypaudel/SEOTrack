using ScrapeFinal.Search;
using ScrapeFinal.Utility;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ScrapeFinal.Models.Operation
{
    public class SearchPageOperation: ISearchPageOperation
    {
        private int urlCounter = 0;
        public List<int> ExtractUrlRank(SearchEngine engine,SearchParameter parameter)
        {
            List<int> result = new List<int>();
            if (engine != null)
            {
                //loop through all pages
                foreach (var currentUrl in engine.searchPages)
                {
                    var html = HTMLLoader.LoadUrl(currentUrl);
                    var tempRanks = ExtractURLRankOnCurrentPage(html, parameter, engine);
                    //for all ranks returned in that page
                    foreach (var rank in tempRanks)
                    {
                        if (rank > 0 && rank<=50)
                        {
                            result.Add(rank);
                        }
                    }

                }
            }
            return result; ;
        }

        private List<int> ExtractURLRankOnCurrentPage(string searchPage, SearchParameter searchParams,SearchEngine engine)
        {
            List<int> rank = new List<int>(); ;
            //check if page has url at all
            var matchingURL = Regex.Matches(searchPage, engine.urlElement);
            if (searchPage.Contains(searchParams.SearchUrl) && urlCounter <= 50)
            {
                //strip all string except those with url element and search url and hold it in a list
                var allMatchingElements = Regex.Matches(searchPage, engine.urlElement + "|" + searchParams.SearchUrl);
                //iterate through list
                for (int i = 0; i < allMatchingElements.Count; i++)
                {
                    //check the array index to avoid index bound error
                    if (i < allMatchingElements.Count - 1)
                    {
                        //if first item in list is html element with list class followed by url then it is confim that the url is on that position
                        if (allMatchingElements[i].ToString() == engine.urlElement && allMatchingElements[i + 1].ToString() == searchParams.SearchUrl)
                        {
                            rank.Add(urlCounter + i + 1);
                            break;
                        }
                    }
                }
            }
            //url counter remember the url position while iterating through pages
            urlCounter = urlCounter + matchingURL.Count;
            return rank;
        }
    }
}