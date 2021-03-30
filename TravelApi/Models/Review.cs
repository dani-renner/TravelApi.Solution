using System.Collections.Generic;
namespace TravelApi.Models
{
  public class Review
  {
    public Review()
    {
      this.JoinEntities = new HashSet<LocationReview>();
    }
    public int ReviewId {get; set; }
    public int Rating { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public virtual ICollection<LocationReview> JoinEntities {get;}
  }
}