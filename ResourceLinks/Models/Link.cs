using System.Collections.Generic;

namespace ResourceLinks.Models
{
  public class Link
  {
    public Link()
    {
        this.Categories = new HashSet<CategoryLink>();
        this.Tags = new HashSet<LinkTag>();
    }
    public int LinkId { get; set; }
    public string ResourceName { get; set; }
    public string LinkUrl { get; set; }
    public string Description { get; set; }
    public ICollection<CategoryLink> Categories { get; }
    public ICollection<LinkTag> Tags { get; }
  }
}