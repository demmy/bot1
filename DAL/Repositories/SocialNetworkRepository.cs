using System.Data.Entity;
using Data.Infrastructure;
using Domain.Entities.Setup;
using BaseOfTalents.DAL.Infrastructure;

namespace BaseOfTalents.DAL.Repositories
{
    public class SocialNetworkRepository : BaseRepository<SocialNetwork>, ISocialNetworkRepository
    {
        public SocialNetworkRepository(DbContext context) : base(context)
        {
        }
    }
}