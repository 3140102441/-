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

        public static int DefaultGrade { get => 3; }

        public ICollection<Record> Records { get; set; }

        [Required]
        public string CreditCardNumber { get; set; }
    }
}
