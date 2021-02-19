

namespace ScrapeFinal.Search
{
    public abstract class SearchEngine
    {
        public abstract string name { get; }
        public abstract string[] searchPages { get; }
        public abstract string urlElement { get; }
    }
}