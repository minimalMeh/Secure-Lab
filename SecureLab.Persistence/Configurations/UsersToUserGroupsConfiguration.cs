using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureLab.Domain.Entities.ComplexEntities;

namespace SecureLab.Persistence.Configurations
{
    public class UsersToUserGroupsConfiguration : IEntityTypeConfiguration<UsersToUserGroups>
    {
        public void Configure(EntityTypeBuilder<UsersToUserGroups> builder)
        {
            builder.HasKey(e => new { e.UserId, e.UserGroupId });

            builder.HasOne(e => e.User)
                .WithMany(g => g.UsersToUserGroups)
                .HasForeignKey(k => k.UserId);

            builder.HasOne(e => e.UserGroup)
               .WithMany(g => g.UsersToUserGroups)
               .HasForeignKey(k => k.UserGroupId);
        }
    }
}
