using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        public string ApplicationUserID { get; set; }

        public ICollection<Record> Records { get; set; }

        public string CreditCardNumber { get; set; }

    }
}
