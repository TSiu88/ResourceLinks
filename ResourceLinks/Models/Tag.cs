using System.Collections.Generic;

namespace ResourceLinks.Models
{
  public class Tag
  {

    public Tag()
    {
      this.Links = new HashSet<LinkTag>();
    }   
    public int TagId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<LinkTag> Links { get; set; }

  }
}