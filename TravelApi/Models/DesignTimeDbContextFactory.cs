using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TravelApi.Models
{
  public class TravelApiContextFactory : IDesignTimeDbContextFactory<TravelApiContext>
  {
    TravelApiContext IDesignTimeDbContextFactory<TravelApiContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.
        GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();
      
      var builder = new DbContextOptionsBuilder<TravelApiContext>();

      builder.UseMySql(configuration
      ["ConnectionStrings:DefaultConnection"]
      , ServerVersion.AutoDetect(configuration
      ["ConnectionStrings:DefaultConnection"])
      );

      return new TravelApiContext(builder.Options);
    }
  }
}