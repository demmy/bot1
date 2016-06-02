using System.Data.Entity;
using DAL.Infrastructure;
using Domain.Entities.Enum.Setup;

namespace DAL.Repositories
{
    public class SkillRepository : BaseRepository<Skill>, ISkillRepository
    {
        public SkillRepository(DbContext context) : base(context)
        {
        }
    }
}