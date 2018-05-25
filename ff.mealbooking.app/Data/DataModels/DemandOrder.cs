using System;
using System.ComponentModel.DataAnnotations;

namespace ff.mealbooking.app.Data.DataModels
{
    public class DemandOrder : BaseEntity
    {
        [MaxLength(512)]
        public string VendorName { get; set; }

        [MaxLength(512)]
        public string CustomerName { get; set; }

        [MaxLength(1024)]
        public string DishName { get; set; }

        [MaxLength(2048)]
        public string Notes { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }
    }
}
