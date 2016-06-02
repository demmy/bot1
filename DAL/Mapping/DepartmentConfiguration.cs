using Domain.Entities.Setup;

namespace Data.EFData.Mapping
{
    public class DepartmentConfiguration : BaseEntityConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            Property(d => d.Title).IsRequired();
        }
    }
}