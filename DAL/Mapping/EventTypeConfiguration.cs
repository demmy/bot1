using Domain.Entities.Enum.Setup;

namespace DAL.Mapping
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