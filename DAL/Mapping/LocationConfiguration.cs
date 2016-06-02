using Domain.Entities.Enum.Setup;

namespace DAL.Mapping
{
    public class LocationConfiguration : BaseEntityConfiguration<Location>
    {
        public LocationConfiguration()
        {
            Property(l => l.Title).IsRequired();
            HasRequired(l => l.Country).WithMany().HasForeignKey(l => l.CountryId);
        }
    }
}