using System.Data.Entity;
using Data.Infrastructure;
using Domain.Entities.Setup;
using BaseOfTalents.DAL.Infrastructure;

namespace BaseOfTalents.DAL.Repositories
{
    public class CityRepository : BaseRepository<Location>, ILocationRepository
    {
        public CityRepository(DbContext context) : base(context)
        {
        }
    }
}