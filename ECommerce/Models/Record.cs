using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Record
    {
        public enum StateType
        {
            NotPaid,
            NotReceived,
            Finished,
            Canceled
        }

        public int ID { get; set; }

        [Required]
        public StateType State { get; set; }

        [Required]
        public int CommodityID { get; set; }

        [Required]
        public int SellerID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime FinishDate { get; set; }
    }
}
