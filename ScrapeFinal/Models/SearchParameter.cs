
using System.ComponentModel.DataAnnotations;


namespace ScrapeFinal.Models
{
    public class SearchParameter
    {
        [Required]
        public string SearchUrl { get; set; }
        [Required]
        public string SearchQuery { get; set; }
    }
}