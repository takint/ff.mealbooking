using System;
using System.ComponentModel.DataAnnotations;

namespace ff.mealbooking.app.Data.DataModels
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
