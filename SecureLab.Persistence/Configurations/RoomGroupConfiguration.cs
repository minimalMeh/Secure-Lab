using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureLab.Domain.Entities;
using SecureLab.Persistence.Converters;

namespace SecureLab.Persistence.Configurations
{
    class RoomGroupConfiguration : IEntityTypeConfiguration<RoomGroup>
    {
        public void Configure(EntityTypeBuilder<RoomGroup> builder)
        {
            builder.HasKey(e => e.Id);

        }
    }
}
