using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Surf.Core.Entities.Users;

namespace Surf.Core.EntitiesMapping.Users
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(e => e.Id);

            builder.Ignore(e => e.EncryptMethod);
        }
    }
}
