using Domain.Entities;

namespace Data.EFData.Mapping
{
    public class CommentConfiguration : BaseEntityConfiguration<Comment>
    {
        public CommentConfiguration()
        {
            Property(c => c.Message).IsRequired();
        }
    }
}