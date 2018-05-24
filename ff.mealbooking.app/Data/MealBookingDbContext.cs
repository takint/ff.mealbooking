﻿using ff.mealbooking.app.Data.DataModels;
using Microsoft.EntityFrameworkCore;

namespace ff.mealbooking.app.Data
{
    public class MealBookingDbContext : DbContext
    {
        public DbSet<DemandOrder> DemandOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=MealBookingDb;User ID=sa;Password=123;Persist Security Info=True;MultipleActiveResultSets=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}