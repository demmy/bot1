using Domain.Entities.Setup;

namespace Data.EFData.Mapping
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