using ScrapeFinal.Models.Operation;
using ScrapeFinal.Search;
using System.Collections.Generic;

namespace ScrapeFinal.Models
{
    public class SearchPageRanker
    {
        ISearchPageOperation _searchOperation;
        List<SearchEngine> SearchEngines { get { return new List<SearchEngine> { new Google(), new Bing() }; } }
        public SearchPageRanker(ISearchPageOperation operation) 
        {
            _searchOperation = operation;
        }
        public List<int> RankURLInPages(SearchEngine engine,SearchParameter param) 
        {
            return _searchOperation.ExtractUrlRank(engine, param);
        }
       

    }
}