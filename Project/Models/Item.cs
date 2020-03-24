using System.Collections.Generic;

namespace ProjectName.Models
{
  public class Item
  {
    public Item()
    {
        this.Categories = new HashSet<CategoryItem>();
    }
    public int ItemId { get; set; }
    public string Description { get; set; }
    public ICollection<CategoryItem> Categories { get; }
  }
}