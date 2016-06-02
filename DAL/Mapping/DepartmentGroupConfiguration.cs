using Domain.Entities.Setup;

namespace Data.EFData.Mapping
{
    public class DepartmentGroupConfiguration : BaseEntityConfiguration<DepartmentGroup>
    {
        public DepartmentGroupConfiguration()
        {
            Property(dg => dg.Title).IsRequired();
        }
    }
}