using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureLab.Domain.Entities;
using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SecureLab.Persistence.Configurations
{
    class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired();

            builder.Property(e => e.Name).IsRequired().HasMaxLength(18);

            builder.Property(e => e.Description).HasMaxLength(256);
        }
    }
}
