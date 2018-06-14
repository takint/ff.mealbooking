using System;
using System.ComponentModel.DataAnnotations;

namespace ff.mealbooking.app.Data.DataModels
{
    public class Betting : BaseEntity
    {
        [MaxLength(512)]
        public string CustomerName { get; set; }

        [MaxLength(1024)]
        public string TeamName { get; set; }

        [MaxLength(2048)]
        public string Match { get; set; }

        public bool TeamWin { get; set; }
    }
}