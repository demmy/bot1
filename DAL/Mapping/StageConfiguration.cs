using Domain.Entities.Setup;

namespace Data.EFData.Mapping
{
    public class StageConfiguration : BaseEntityConfiguration<Stage>
    {
        public StageConfiguration()
        {
            Property(sn => sn.Title).IsRequired();
        }
    }
}