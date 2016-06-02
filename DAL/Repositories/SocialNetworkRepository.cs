using System.Data.Entity;
using DAL.Infrastructure;
using Domain.Entities.Enum.Setup;

namespace DAL.Repositories
{
    public class SocialNetworkRepository : BaseRepository<SocialNetwork>, ISocialNetworkRepository
    {
        public SocialNetworkRepository(DbContext context) : base(context)
        {
        }
    }
}