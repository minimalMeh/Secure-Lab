using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SecureLab.Persistence
{
    class SecureLabDbContextFactory : IDesignTimeDbContextFactory<SecureLabDbContext>
    {
        public SecureLabDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SecureLabDbContext>();
            //TODO: insert connection string
            optionsBuilder.UseSqlServer("" /*connection string*/);

            return new SecureLabDbContext(optionsBuilder.Options);
        }
    }
}
