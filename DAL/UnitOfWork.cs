using BaseOfTalents.DAL.Infrastructure;
using BaseOfTalents.DAL.Repositories;
using DAL.Infrastructure;
using DAL.Repositories;
using System.Data.Entity;

namespace BaseOfTalents.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext context;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public UnitOfWork()
        {
            context = new BOTContext();
        }

        public ICandidateRepository CandidateRepo
        {
            get
            {
                if (candidateRepo == null)
                {
                    candidateRepo = new CandidateRepository(context);
                }

                return candidateRepo;
            }
        }

        public IFileRepository FileRepo
        {
            get
            {
                if (fileRepo == null)
                {
                    fileRepo = new FileRepository(context);
                }

                return fileRepo;
            }
        }

        public IUserRepository UserRepo
        {
            get
            {
                if (userRepo == null)
                {
                    userRepo = new UserRepository(context);
                }

                return userRepo;
            }
        }

        public ILevelRepository LevelRepo
        {
            get
            {
                if (levelRepo == null)
                {
                    levelRepo = new LevelRepository(context);
                }

                return levelRepo;
            }
        }

        public IVacancyRepository VacancyRepo
        {
            get
            {
                if (vacancyRepo == null)
                {
                    vacancyRepo = new VacancyRepository(context);
                }

                return vacancyRepo;
            }
        }

        public ILocationRepository LocationRepo
        {
            get
            {
                if (locationRepo == null)
                {
                    locationRepo = new LocationRepository(context);
                }

                return locationRepo;
            }
        }

        public ITagRepository TagRepo
        {
            get
            {
                if (tagRepo == null)
                {
                    tagRepo = new TagRepository(context);
                }

                return tagRepo;
            }
        }


        public ISkillRepository SkillRepo
        {
            get
            {
                if (skillRepo == null)
                {
                    skillRepo = new SkillRepository(context);
                }

                return skillRepo;
            }
        }
        public ILanguageSkillRepository LanguageSkillRepo
        {
            get
            {
                if (languageSkillRepo == null)
                {
                    languageSkillRepo = new LanguageSkillRepository(context);
                }

                return languageSkillRepo;
            }
        }

        public IVacancyStageRepository VacancyStageRepo
        {
            get
            {
                if (vacancyStageRepo == null)
                {
                    vacancyStageRepo = new VacancyStageRepository(context);
                }

                return vacancyStageRepo;
            }
        }

        private IFileRepository fileRepo;
        private ICandidateRepository candidateRepo;
        private IUserRepository userRepo;
        private IVacancyRepository vacancyRepo;
        private ILevelRepository levelRepo;
        private ILocationRepository locationRepo;
        private ITagRepository tagRepo;
        private ISkillRepository skillRepo;
        private ILanguageSkillRepository languageSkillRepo;
        private IVacancyStageRepository vacancyStageRepo;



        public void Commit()
        {
            context.SaveChanges();
        }
    }
}