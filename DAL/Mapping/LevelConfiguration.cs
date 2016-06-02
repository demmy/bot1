using Domain.Entities.Enum.Setup;

namespace Data.EFData.Mapping
{
    public class LevelConfiguration : BaseEntityConfiguration<Level>
    {
        public LevelConfiguration()
        {
            Property(l => l.Title).IsRequired();
        }
    }
}