using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicCommerce.Models
{
    public class Commodity
    {
        public enum GenreType
        {
            Book,
            Clothes,
            Food
        }

        public int ID { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int SellerID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public GenreType Genre { get; set; }

        public ICollection<ImagePath> ImagePaths { get; set; }
    }
}
