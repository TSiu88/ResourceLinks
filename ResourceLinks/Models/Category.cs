using System.Collections.Generic;

namespace ResourseLinks.Models
{
  public class Category
  {

    public Category()
    {
      this.Links = new HashSet<CategoryLink>();
    }
    public int CategoryId { get; set; }
    public string Title { get; set; }
    public virtual ICollection<CategoryLink> Links { get; set; }

    public Category()
    {
      this.Links = new HashSet<CategoryLink>();
    }
  }
}