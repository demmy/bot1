using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseOfTalents.DAL.Infrastructure;
using BaseOfTalents.DAL.Repositories;
using Data.EFData;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        DbContext context;

        IUserRepository userRepo;
        ICandidateRepository candidateRepo;
        IFileRepository fileRepo;
        IVacancyRepository vacancyRepo;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }
        public UnitOfWork()
        {
            this.context = new BOTContext();
        }

        public ICandidateRepository CandidateRepo
        {
            get
            {
                if (this.candidateRepo == null)
                {
                    this.candidateRepo = new CandidateRepository(context);
                }

                return candidateRepo;
            }
        }

        public IFileRepository FileRepo
        {
            get
            {
                if (this.fileRepo == null)
                {
                    this.fileRepo = new FileRepository(context);
                }

                return fileRepo;
            }
        }

        public IUserRepository UserRepo
        {
            get
            {
                if (this.userRepo == null)
                {
                    this.userRepo = new UserRepository(context);
                }

                return userRepo;
            }
        }

        public IVacancyRepository VacancyRepo
        {
            get
            {
                if (this.vacancyRepo == null)
                {
                    this.vacancyRepo = new VacancyRepository(context);
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
