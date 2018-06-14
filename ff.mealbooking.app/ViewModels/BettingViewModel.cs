using System;

namespace ff.mealbooking.app.ViewModels
{
    public class BettingViewModel
    {
        public string CustomerName { get; set; }

        public string TeamName { get; set; }

        public string Match { get; set; }

        public bool TeamWin { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}