using System.Collections.Generic;

namespace ProjectName.Models
{
  public class Category
  {
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<CategoryItem> Items { get; set; }

    public Category()
    {
      this.Items = new HashSet<CategoryItem>();
    }
  }
}