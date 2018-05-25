using System;
using System.ComponentModel.DataAnnotations;

namespace ff.mealbooking.app.ViewModels
{
    public class MealVoteViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Quán or Link")]
        public string VendorName { get; set; }

        [Display(Name = "Người đặt")]
        public string CustomerName { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
