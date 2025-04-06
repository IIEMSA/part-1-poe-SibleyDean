using Microsoft.EntityFrameworkCore;
using eventEasefour.Models;
using static eventEasefour.Models.Bookings;



namespace eventEasefour.Data
{
    public class ApplicationDbContext: DbContext
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
            modelBuilder.Entity<Bookings>()
                .HasIndex(b => new { b.EventId, b.VenueId })
                .IsUnique();
        }
    }
}
