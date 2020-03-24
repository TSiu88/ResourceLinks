namespace ResourceLinks.Models
{
  public class LinkTag
  {       
    public int LinkTagId { get; set; }
    public int LinkId { get; set; }
    public int TagId { get; set; }
    public Link Link { get; set; }
    public Tag Tag { get; set; }
  }
}