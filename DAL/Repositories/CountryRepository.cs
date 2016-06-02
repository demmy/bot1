using System.Data.Entity;
using DAL.Infrastructure;
using Domain.Entities.Enum.Setup;

namespace DAL.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(DbContext context) : base(context)
        {
        }
    }
}