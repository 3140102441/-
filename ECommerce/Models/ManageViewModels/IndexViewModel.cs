using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string CreditCardNumber { get; set; }
        public bool IsSeller { get; set; }

        public ICollection<Record> Records { get; set; }
    }
}
