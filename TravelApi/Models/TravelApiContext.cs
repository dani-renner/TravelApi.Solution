using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public TravelApiContext(DbContextOptions<TravelApiContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Location>()
      .HasData(
        new Location { LocationId = 1, Country = "Zimbabwe", City = "Bulawayo" },
        new Location { LocationId = 2, Country = "Argentina", City = "Rosario" },
        new Location { LocationId = 3, Country = "Luxembourg", City = "Luxembourg" },
        new Location { LocationId = 4, Country = "Nepal", City = "Bharatpur" },
        new Location { LocationId = 5, Country = "Kazakhstan", City = "Almaty" }
      );
      builder.Entity<Review>()
      .HasData(
        new Review { ReviewId = 1, Rating = 3, Title = "Perfect Weather!", Text = "Every day is comfortable and beautiful outside. But water supply is a big problem.", LocationId = 1},
        new Review { ReviewId = 2, Rating = 3, Title = "Gorgeous Weather!", Text = "Every day is comfortable and beautiful outside. But there is crime and violence.", LocationId = 2},
        new Review { ReviewId = 3, Rating = 2, Title = "Gloomy & Expensive!", Text = "The rent is too damned high!", LocationId = 3},
        new Review { ReviewId = 4, Rating = 5, Title = "Love the food!", Text = "There are wonderful flavors and spices here, and it's not too intense!", LocationId = 4},
        new Review { ReviewId = 5, Rating = 1, Title = "Ladies, don't go!", Text = "The men here sure are not respectful to women!", LocationId = 5}
      );
    }

    public DbSet<Location> Locations { get; set; }
    public DbSet<Review> Reviews { get; set; }
  } 
}