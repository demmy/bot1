using Domain.Entities.Enum.Setup;

namespace Data.EFData.Mapping
{
    public class TagConfiguration : BaseEntityConfiguration<Tag>
    {
        public TagConfiguration()
        {
            Property(t => t.Title).IsRequired();
        }
    }
}