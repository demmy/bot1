using BaseOfTalents.DAL.Infrastructure;
using BaseOfTalents.DAL.Repositories;
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

        private IFileRepository fileRepo;
        private ICandidateRepository candidateRepo;
        private IUserRepository userRepo;
        private IVacancyRepository vacancyRepo;

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}