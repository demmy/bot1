using System.Data.Entity;
using DAL.Infrastructure;
using Domain.Entities;

namespace DAL.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}