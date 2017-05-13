using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models.BrowseViewModels
{
    public class IndexViewModel
    {
        public class Commodity
        {
            public string Name { get; set; }
            public ICollection<string> ImagePaths { get; set; }
            public string Genre { get; set; }
        }

        public ICollection<Commodity> Commodities { get; set; }

        public string SearchString { get; set; }

        public ICollection<string> Genres;

        public string Genre { get; set; }
    }
}
