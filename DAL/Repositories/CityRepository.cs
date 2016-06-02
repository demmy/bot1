using System.Data.Entity;
using DAL.Infrastructure;
using Domain.Entities.Enum.Setup;

namespace DAL.Repositories
{
    public class CityRepository : BaseRepository<Location>, ILocationRepository
    {
        public CityRepository(DbContext context) : base(context)
        {
        }
    }
}