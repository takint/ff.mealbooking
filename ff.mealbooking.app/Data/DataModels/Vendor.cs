using System.ComponentModel.DataAnnotations;

namespace ff.mealbooking.app.Data.DataModels
{
    public class Vendor : BaseEntity
    {
        [MaxLength(1024)]
        public string Name { get; set; }

        public string LinkUrl { get; set; }

        public string Discount { get; set; }
    }
}
