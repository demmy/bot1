using System.Data.Entity;
using Data.Infrastructure;
using Domain.Entities;
using BaseOfTalents.DAL.Infrastructure;

namespace BaseOfTalents.DAL.Repositories
{
    public class CandidateRepository : BaseRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(DbContext context) : base(context)
        {
        }
    }
}