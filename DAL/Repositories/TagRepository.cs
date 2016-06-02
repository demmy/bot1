using System.Data.Entity;
using Data.Infrastructure;
using Domain.Entities.Enum.Setup;
using BaseOfTalents.DAL.Infrastructure;

namespace BaseOfTalents.DAL.Repositories
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(DbContext context) : base(context)
        {
        }
    }
}