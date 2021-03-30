using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
    public class TravelApiContext : DbContext
    {
        public TravelApiContext(DbContextOptions<TravelApiContext> options)
            : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Review> Reviews { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //   modelBuilder.Entity<Location>()
        //     .HasMany(r => r.Reviews)
        //     .WithOne(l => l.Location);
        // }
    } 
}