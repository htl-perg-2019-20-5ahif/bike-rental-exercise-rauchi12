using BikeRentalAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRentalAPI.Data
{
    public class BikeRentalDbContext: DbContext
    {
        public BikeRentalDbContext(DbContextOptions<BikeRentalDbContext> options) : base(options)
        { }
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Bike>()
            //    .Property(b => b.BikeCategory)
            //    .IsRequired
        }
    }
}
