using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureLab.Domain.Entities;
using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SecureLab.Persistence.Configurations
{
    class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        private  readonly ValueConverter _rolesConverter = new ValueConverter<string[], string>
        (v => string.Join(";", v),
            v => v.Split(";", StringSplitOptions.RemoveEmptyEntries));
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnName("GroupId");

            builder.Property(e => e.AllowedRolesId).HasConversion(_rolesConverter);
        }
    }
}
