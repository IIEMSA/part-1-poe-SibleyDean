using Microsoft.EntityFrameworkCore;
using eventEasefour.Models;

namespace eventEasefour.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Bookings> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bookings>()
                .HasIndex(b => new { b.EventId, b.VenueId })
                .IsUnique();

            modelBuilder.Entity<Venue>().ToTable("Venue");
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Bookings>().ToTable("Booking");
        }
    }
}