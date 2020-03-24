using Microsoft.EntityFrameworkCore;

namespace ResourceLinks.Models
{
  public class ResourceLinksContext : DbContext
  {
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Link> Links { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<CategoryLink> CategoryLink { get; set; }

    public ResourceLinksContext(DbContextOptions options) : base(options) { }
  }
}