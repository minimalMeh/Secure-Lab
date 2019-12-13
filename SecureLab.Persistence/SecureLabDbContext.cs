using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SecureLab.Persistence
{
    class SecureLabDbContext : DbContext
    {
        public SecureLabDbContext(DbContextOptions<SecureLabDbContext> options)
            : base(options)
        {
        }
    }
}
