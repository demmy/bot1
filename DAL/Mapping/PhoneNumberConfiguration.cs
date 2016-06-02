using Domain.Entities;

namespace Data.EFData.Mapping
{
    public class PhoneNumberConfiguration : BaseEntityConfiguration<PhoneNumber>
    {
        public PhoneNumberConfiguration()
        {
            Property(p => p.Number).IsRequired();
        }
    }
}