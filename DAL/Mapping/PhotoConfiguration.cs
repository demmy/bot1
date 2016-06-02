using Domain.Entities;

namespace Data.EFData.Mapping
{
    public class PhotoConfiguration : BaseEntityConfiguration<Photo>
    {
        public PhotoConfiguration()
        {
            Property(p => p.ImagePath).IsRequired();
            Property(p => p.Description);
        }
    }
}