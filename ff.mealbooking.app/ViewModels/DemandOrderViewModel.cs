using System;
using System.ComponentModel.DataAnnotations;

namespace ff.mealbooking.app.ViewModels
{
    public class DemandOrderViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Quán")]
        public string VendorName { get; set; }

        [Required]
        [Display(Name = "Người đặt")]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Món ăn")]
        public string DishName { get; set; }

        [Display(Name = "Ghi chú")]
        public string Notes { get; set; }

        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }

        [Display(Name = "Giá tiền")]
        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
