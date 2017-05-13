using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Seller
    {

        public int ID { get; set; }

        [Required]
        public string ApplicationUserID { get; set; }

        public ICollection<Commodity> Commodities { get; set; }

        [Required]
        [Range(0, 5)]
        public int Grade { get; set; }

        public ICollection<Record> Records { get; set; }

        [Required]
        public string CreditCardNumber { get; set; }
    }
}
