using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicCommerce.Models
{
    public class Comment
    {
        public int ID { get; set; }

        [Required]
        public int CommodityID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int Content { get; set; }
        [Required]
        [Range(0, 5)]
        public int Grade { get; set; }
    }
}
