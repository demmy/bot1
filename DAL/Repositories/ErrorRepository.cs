using System.Data.Entity;
using Data.Infrastructure;
using Domain.Entities;
using BaseOfTalents.DAL.Infrastructure;

namespace BaseOfTalents.DAL.Repositories
{
    public class ErrorRepository : BaseRepository<Error>, IErrorRepository
    {
        public ErrorRepository(DbContext context) : base(context)
        {
        }
    }
}