using System;
using System.ComponentModel.DataAnnotations;

namespace ff.mealbooking.app.Data.DataModels
{
    public class MealVote : BaseEntity
    {
        [MaxLength(512)]
        public string CustomerName { get; set; }

        [MaxLength(1024)]
        public string VendorName { get; set; }
    }
}
