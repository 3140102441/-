using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicCommerce.Models
{
    public class Seller
    {
        public const int DefaultGrade = 3;

        public int ID { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ApplicationUserID { get; set; }
        [Required]
        public string CreditCardNumber { get; set; }

        public ICollection<Record> Records { get; set; }
        public ICollection<Commodity> Commodities { get; set; }
    }
}
