using System.Collections.Generic;

namespace ResourseLinks.Models
{
  public class Link
  {
    public Link()
    {
        this.Categories = new HashSet<CategoryLink>();
        this.Tags = new HashSet<TagLink>();
    }
    public int LinkId { get; set; }
    public string ResourseName { get; set; }
    public string LinkUrl { get; set; }
    public string Description { get; set; }
    public ICollection<CategoryLink> Categories { get; }
    public ICollection<TagLink> Tags { get; }
  }
}