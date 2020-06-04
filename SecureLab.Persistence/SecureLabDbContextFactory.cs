using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SecureLab.Persistence;

namespace SecureLab
{
    public class SecureLabDbContextFactory : IDesignTimeDbContextFactory<SecureLabDbContext>
    {
        public SecureLabDbContext CreateDbContext(string[] args)
        {
            return new SecureLabDbContext(GetOptions());
        }
        
        public static DbContextOptions<SecureLabDbContext> GetOptions()
        {
            var optionsBuilder = new DbContextOptionsBuilder<SecureLabDbContext>();

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();

            var connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
            return optionsBuilder.Options;
        }
    }
}
