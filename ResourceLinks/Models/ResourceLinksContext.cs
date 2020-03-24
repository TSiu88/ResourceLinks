using Microsoft.EntityFrameworkCore;

namespace ProjectName.Models
{
  public class ProjectNameContext : DbContext
  {
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Link> Links { get; set; }
    public DbSet<CategoryLink> CategoryLink { get; set; }

    public ProjectNameContext(DbContextOptions options) : base(options) { }
  }
}