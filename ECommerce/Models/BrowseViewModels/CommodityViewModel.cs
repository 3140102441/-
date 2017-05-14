using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models.BrowseViewModels
{
    public class CommodityViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<string> ImagePaths { get; set; }
        public string Genre { get; set; }
        public int ID { get; set; }
    }
}
