using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ResourceLinks.Models
{
  public class ResourseLinksContextFactory : IDesignTimeDbContextFactory<ResourceLinksContext>
  {

    ResourceLinksContext IDesignTimeDbContextFactory<ResourceLinksContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<ResourceLinksContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new ResourceLinksContext(builder.Options);
    }
  }
}