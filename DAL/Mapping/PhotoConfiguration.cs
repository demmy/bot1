using Domain.Entities;

namespace DAL.Mapping
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