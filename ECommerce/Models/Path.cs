using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class ImagePath
    {
        public int ID { get; set; }

        [Required]
        public int CommodityID { get; set; }

        [Required]
        public string ExtendedName { get; set; }

        public string FullPath()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot", @"CommodityImage", ID.ToString() + ExtendedName);
        }
    }
}
