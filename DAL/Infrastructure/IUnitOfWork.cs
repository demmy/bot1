using DAL.Infrastructure;

namespace BaseOfTalents.DAL.Infrastructure
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepo { get; }
        IVacancyRepository VacancyRepo { get; }
        ICandidateRepository CandidateRepo { get; }
        IFileRepository FileRepo { get; }
        ILevelRepository LevelRepo { get; }
        ILocationRepository LocationRepo { get; }
        ITagRepository TagRepo { get; }
        ISkillRepository SkillRepo { get; }
        ILanguageSkillRepository LanguageSkillRepo { get; }
        IVacancyStageRepository VacancyStageRepo { get; }


        void Commit();
    }
}