namespace ResourseLinks.Models
{
  public class CategoryLink
  {       
    public int CategoryLinkId { get; set; }
    public int LinkId { get; set; }
    public int CategoryId { get; set; }
    public Link Link { get; set; }
    public Category Category { get; set; }
  }
}