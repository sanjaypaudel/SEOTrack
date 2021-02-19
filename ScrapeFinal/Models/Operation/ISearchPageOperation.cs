using ScrapeFinal.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeFinal.Models.Operation
{
    public interface ISearchPageOperation
    {
         List<int> ExtractUrlRank(SearchEngine search, SearchParameter param);
    }
}
