using Domain.Entities;

namespace Data.EFData.Mapping
{
    public class FileConfiguration : BaseEntityConfiguration<File>
    {
        public FileConfiguration()
        {
            Property(f => f.FilePath).IsRequired();
            Property(f => f.Description).IsOptional();
        }
    }
}