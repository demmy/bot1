using BaseOfTalents.DAL.DTO;
using BaseOfTalents.DAL.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace BaseOfTalents.DAL.Services
{
    public class VacancyService
    {
        private readonly IUnitOfWork uow;

        public VacancyService()
        {
            uow = new UnitOfWork();
        }

        public VacancyService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public IEnumerable<VacancyDTO> Get(int page, int pageSize)
        {
            return uow.VacancyRepo.Get(page: page, pageSize: pageSize)
                .Select(vacancy =>
                    new VacancyDTO
                    {
                        CandidatesProgress = vacancy.CandidatesProgress,
                        Comments = vacancy.Comments,
                        DeadlineDate = vacancy.DeadlineDate,
                        Department = vacancy.Department,
                        Description = vacancy.Description,
                        EndDate = vacancy.EndDate,
                        Files = vacancy.Files,
                        Industry = vacancy.Industry,
                        LanguageSkill = vacancy.LanguageSkill,
                        Levels = vacancy.Levels,
                        Locations = vacancy.Locations,
                        ParentVacancy = vacancy.ParentVacancy,
                        RequiredSkills = vacancy.RequiredSkills,
                        Responsible = vacancy.Responsible,
                        SalaryMax = vacancy.SalaryMax,
                        SalaryMin = vacancy.SalaryMin,
                        StartDate = vacancy.StartDate,
                        Tags = vacancy.Tags,
                        Title = vacancy.Title,
                        TypeOfEmployment = vacancy.TypeOfEmployment
                    }
                );
        }
    }
}