using System;
using System.ComponentModel.DataAnnotations;

namespace ff.mealbooking.app.ViewModels
{
    public class VendorViewModel
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public string Name { get; set; }

        public string LinkUrl { get; set; }

        public string Discount { get; set; }
    }
}
