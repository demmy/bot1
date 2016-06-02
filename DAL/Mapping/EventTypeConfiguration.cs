using Domain.Entities.Setup;

namespace Data.EFData.Mapping
{
    public class EventTypeConfiguration : BaseEntityConfiguration<EventType>
    {
        public EventTypeConfiguration()
        {
            Property(et => et.ImagePath).IsRequired();
            Property(et => et.Title).IsRequired();
        }
    }
}