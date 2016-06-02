using System.Data.Entity;
using DAL.Infrastructure;
using Domain.Entities;

namespace DAL.Repositories
{
    public class ErrorRepository : BaseRepository<Error>, IErrorRepository
    {
        public ErrorRepository(DbContext context) : base(context)
        {
        }
    }
}