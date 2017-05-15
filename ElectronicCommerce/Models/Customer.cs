using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicCommerce.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        public string ApplicationUserID { get; set; }
        public string CreditCardNumber { get; set; }
        public string Location { get; set; }

        public ICollection<Record> Records { get; set; }
    }
}
