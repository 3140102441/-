using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Path
    {
        [RegularExpression(@"^[a-zA-Z0-9]+$")]
        [StringLength(30)]
        public string ID { get; set; }

        [Required]
        public string CommodityID { get; set; }

        [Required]
        public string ExtendedName { get; set; }
    }
}
