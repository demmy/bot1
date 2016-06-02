using System.Data.Entity;
using Data.Infrastructure;
using Domain.Entities.Enum.Setup;
using BaseOfTalents.DAL.Infrastructure;

namespace BaseOfTalents.DAL.Repositories
{
    public class LevelRepository : BaseRepository<Level>, ILevelRepository
    {
        public LevelRepository(DbContext context) : base(context)
        {
        }
    }
}