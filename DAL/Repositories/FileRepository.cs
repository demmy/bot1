using System.Data.Entity;
using DAL.Infrastructure;
using Domain.Entities;

namespace DAL.Repositories
{
    public class FileRepository : BaseRepository<File>, IFileRepository
    {
        public FileRepository(DbContext context) : base(context)
        {
        }
    }
}