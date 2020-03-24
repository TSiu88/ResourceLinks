using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ResourseLinks.Models
{
  public class ResourseLinksContextFactory : IDesignTimeDbContextFactory<ResourseLinksContext>
  {

    ProjectNameContext IDesignTimeDbContextFactory<ResourseLinksContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<ResourseLinksContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new ResourseLinksContext(builder.Options);
    }
  }
}