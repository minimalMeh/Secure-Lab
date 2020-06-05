using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureLab.Domain.Entities;

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
