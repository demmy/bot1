namespace DAL.Infrastructure
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepo { get; }
        IVacancyRepository VacancyRepo { get; }
        ICandidateRepository CandidateRepo { get; }
        IFileRepository FileRepo { get; }
        void Commit();
    }
}