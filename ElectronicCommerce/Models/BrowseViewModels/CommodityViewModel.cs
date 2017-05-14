using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicCommerce.Models.BrowseViewModels
{
    public class CommodityViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Models.Commodity.GenreType Genre { get; set; }
        public int ID { get; set; }

        public ICollection<string> ImagePaths { get; set; }
    }
}
