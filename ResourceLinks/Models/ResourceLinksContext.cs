using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ResourceLinks.Models
{
  public class ResourceLinksContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Link> Links { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<CategoryLink> CategoryLink { get; set; }
    public DbSet<LinkTag> LinkTag { get; set; }

    public ResourceLinksContext(DbContextOptions options) : base(options) { }
  }
}