using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicCommerce.Models.BrowseViewModels
{
    public class SearchViewModel
    {
        public class Commodity
        {
            public string Name { get; set; }
            public ICollection<string> ImagePaths { get; set; }
            public Models.Commodity.GenreType Genre { get; set; }
            public int ID { get; set; }
        }

        public ICollection<Commodity> Commodities { get; set; }
    }
}
