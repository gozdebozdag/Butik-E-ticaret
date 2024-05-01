using BotuqieButik.data.Entitis;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BotuqieButik.data.Config
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
