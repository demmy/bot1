using System.Data.Entity;
using DAL.Infrastructure;
using Domain.Entities;

namespace DAL.Repositories
{
    public class CandidateRepository : BaseRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(DbContext context) : base(context)
        {
        }
    }
}