using System.Data.Entity;
using DAL.Infrastructure;
using DAL.Repositories;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICandidateRepository candidateRepo;
        private readonly DbContext context;
        private IFileRepository fileRepo;

        private IUserRepository userRepo;
        private IVacancyRepository vacancyRepo;

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

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}