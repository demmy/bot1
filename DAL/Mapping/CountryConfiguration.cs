using Domain.Entities.Setup;

namespace Data.EFData.Mapping
{
    public class CountryConfiguration : BaseEntityConfiguration<Country>
    {
        public CountryConfiguration()
        {
            Property(c => c.Title).IsRequired();
        }
    }
}