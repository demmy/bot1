using BaseOfTalents.DAL.Infrastructure;
using System.Data.Entity;

namespace Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();

        IUserRepository UserRepo { get; }
        IVacancyRepository VacancyRepo { get; }
        ICandidateRepository CandidateRepo { get; }
        IFileRepository FileRepo { get; }
    }
}