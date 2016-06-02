using System.Data.Entity;
using DAL.Infrastructure;
using Domain.Entities.Enum.Setup;

namespace DAL.Repositories
{
    public class LevelRepository : BaseRepository<Level>, ILevelRepository
    {
        public LevelRepository(DbContext context) : base(context)
        {
        }
    }
}