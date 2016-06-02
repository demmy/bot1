using Domain.Entities.Enum.Setup;

namespace Data.EFData.Mapping
{
    public class IndustryConfiguration : BaseEntityConfiguration<Industry>
    {
        public IndustryConfiguration()
        {
            Property(i => i.Title).IsRequired();
        }
    }
}