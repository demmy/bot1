using Domain.Entities.Setup;

namespace Data.EFData.Mapping
{
    internal class RoleConfiguration : BaseEntityConfiguration<Role>
    {
        public RoleConfiguration()
        {
            Property(r => r.Title);
            HasMany(r => r.Permissions).WithMany(p => p.Roles);
        }
    }
}