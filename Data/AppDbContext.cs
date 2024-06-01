using Microsoft.EntityFrameworkCore;
using HotelBookingApi.Models;
using System.Collections.Generic;

namespace HotelBookingApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Name = "Hotel 1", Location = "City A" },
                new Hotel { Id = 2, Name = "Hotel 2", Location = "City B" },
                new Hotel { Id = 3, Name = "Hotel 3", Location = "City C" }
            );
        }
    }
}
