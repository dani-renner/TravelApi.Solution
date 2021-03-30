using System.Collections.Generic;

namespace TravelApi.Models
{
  public class Location
  {
    public Location()
    {
      this.Reviews = new HashSet<Review>();
    }
    public int LocationId { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public ICollection<Review> Reviews { get; set; }
  }
}