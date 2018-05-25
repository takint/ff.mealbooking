using System;
using System.ComponentModel.DataAnnotations;

namespace ff.mealbooking.app.Data.DataModels
{
    public class MealVote
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(512)]
        public string CustomerName { get; set; }

        [MaxLength(1024)]
        public string VendorName { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
