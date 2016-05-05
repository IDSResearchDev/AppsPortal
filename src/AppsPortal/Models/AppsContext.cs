using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppsPortal.Models
{
    public class AppsContext : DbContext
    {
        public AppsContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Release> Releases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = Startup.Configuration["Data:AppsContextConnection"];
            optionsBuilder.UseSqlServer(connString);

            base.OnConfiguring(optionsBuilder);
        }

    }
}
