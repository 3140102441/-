using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicCommerce.Models.BrowseViewModels
{
    public class PayViewModel
    {
        public class Commodity
        {
            public string Name { get; set; }
            public ICollection<string> ImagePaths { get; set; }
            public int ID { get; set; }
        }

        public class Buyer
        {
            public string UserName { get; set; }
            public string CreditCardNumber { get; set; }
            public string Location { get; set; }
        }

        public Commodity comm;
        public Buyer buyer;
    }
}
