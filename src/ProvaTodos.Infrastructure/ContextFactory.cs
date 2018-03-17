using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace ProvaTodos.Infrastructure
{
    public class MyDbContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var environmentName =
                Environment.GetEnvironmentVariable(
                    "Hosting:Environment");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json", true)
                .AddEnvironmentVariables()
                .Build();


            var builder = new DbContextOptionsBuilder<Context>();

            var connectionString = configuration.GetConnectionString(configuration["Database:DefaultConnection"]);

            builder.UseSqlServer(connectionString);

            return new Context(builder.Options);
        }
    }
}