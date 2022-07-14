using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App.Domain.Core.BaseData.Entity;
using App.Domain.Core.Customer.Entity;
using App.Domain.Core.Expert.Entity;


namespace App.Infrastructures.Database.SqlServer
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = .; Database = Final; User Id = sa; Password = 123456;");
        }
        public DbSet<CategurySKill> CategurySKill { get; set; }
        public DbSet<OrderStates> OrderStates { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<CustomerCategurySKill> CustomerCategurySKill { get; set; }
        public DbSet<Customers> Customers { get; set; }

        public DbSet<ExpertCategurySKill> expertCateguryServices { get; set; }
        public DbSet<Experts> Experts { get; set; }

    }
}
