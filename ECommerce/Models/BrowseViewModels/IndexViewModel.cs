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
            public ICollection<string> Paths { get; set; }
            public int CommodityID { get; set; }
        }

        public ICollection<Commodity> Commodities;
    }
}
