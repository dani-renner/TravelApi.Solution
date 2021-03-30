using System.Collections.Generic;

namespace TravelApi.Models
{
  public class Location
  {
    public Location()
    {
      this.JoinEntities = new HashSet<LocationReview>();
    }
    public int LocationId { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public ICollection<LocationReview> JoinEntities { get; }
  }
}