using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ProjectName.Models
{
  public class ProjectNameContextFactory : IDesignTimeDbContextFactory<ProjectNameContext>
  {

    ProjectNameContext IDesignTimeDbContextFactory<ProjectNameContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<ProjectNameContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new ProjectNameContext(builder.Options);
    }
  }
}