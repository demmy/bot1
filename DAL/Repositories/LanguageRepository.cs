using System.Data.Entity;
using DAL.Infrastructure;
using Domain.Entities.Enum.Setup;

namespace DAL.Repositories
{
    public class LanguageRepository : BaseRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(DbContext context) : base(context)
        {
        }
    }
}