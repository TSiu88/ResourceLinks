using System.Collections.Generic;

namespace ResourseLinks.Models
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

    public Category()
    {
      this.Links = new HashSet<LinkTag>();
    }
  }
}