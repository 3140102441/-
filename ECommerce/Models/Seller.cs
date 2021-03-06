﻿using System;
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

        [Required]
        [Range(0, 5)]
        public int Grade { get; set; }
        [Required]
        public double TotalGrade { get; set; }
        [Required]
        public int GradeQuantity { get; set; }

        public ICollection<Record> Records { get; set; }

        [Required]
        public string CreditCardNumber { get; set; }
    }
}
