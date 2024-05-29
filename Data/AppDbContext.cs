using Microsoft.EntityFrameworkCore;
using HotelBookingApi.Models;

namespace HotelBookingApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure EF Core to use the in-memory database
            optionsBuilder.UseInMemoryDatabase("HotelBookingInMemoryDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Name = "Hotel A", Location = "City X", Picture = "pictureA.jpg" },
                new Hotel { Id = 2, Name = "Hotel B", Location = "City Y", Picture = "pictureB.jpg" }
            );
        }
    }
}
