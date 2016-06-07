using BaseOfTalents.DAL.Infrastructure;
using BaseOfTalents.Domain.Entities;
using DAL.Exceptions;
using DAL.Extensions;
using DAL.Services;
using Domain.DTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BaseOfTalents.DAL.Services
{
    public partial class VacancyService
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

        public VacancyDTO Get(int id)
        {
            var vacancy = uow.VacancyRepo.GetByID(id);
            return DTOService.ToDTO<Vacancy, VacancyDTO>(vacancy);
        }

        public Tuple<IEnumerable<VacancyDTO>, int> Get(
            int? userId,
            int? industryId,
            string title,
            int? vacancyState,
            int? typeOfEmployment,
            IEnumerable<int> levelIds,
            IEnumerable<int> locationIds, 
            int current,
            int size
            )
        {
            var filters = new List<Expression<Func<Vacancy, bool>>>();

            if (userId.HasValue)
            {
                filters.Add(x => x.Responsible.Id == userId);
            }
            if (industryId.HasValue)
            {
                filters.Add(x => x.IndustryId == industryId);
            }
            if (!String.IsNullOrEmpty(title))
            {
                filters.Add(x => x.Title.ToLower().Contains(title.ToLower()));
            }
            if (vacancyState.HasValue)
            {
                filters.Add(x => (int)x.State == vacancyState);
            }
            if (typeOfEmployment.HasValue)
            {
                filters.Add(x => (int)x.TypeOfEmployment == typeOfEmployment);
            }
            if (levelIds.Any())
            {
                filters.Add(x => x.Levels.Any(l => levelIds.Contains(l.Id)));
            }
            if (locationIds.Any())
            {
                filters.Add(x => x.Locations.Any(loc => locationIds.Contains(loc.Id)));
            }

            var vacancies = uow.VacancyRepo.Get(filters);
            var total = vacancies.Count();
            return new Tuple<IEnumerable<VacancyDTO>, int>(
                vacancies.Skip(current * size).Take(size).Select(vacancy => DTOService.ToDTO<Vacancy, VacancyDTO>(vacancy)),
                total);
        }

        public VacancyDTO Update(VacancyDTO vacancy)
        {
            var vacancyToUpdate = uow.VacancyRepo.GetByID(vacancy.Id);
            vacancyToUpdate.Update(vacancy, uow);
            uow.VacancyRepo.Update(vacancyToUpdate);
            uow.Commit();
            return DTOService.ToDTO<Vacancy, VacancyDTO>(vacancyToUpdate);
        }

        public VacancyDTO Add(VacancyDTO vacancy)
        {
            var vacancyToAdd = new Vacancy();
            vacancyToAdd.Update(vacancy, uow);
            uow.VacancyRepo.Insert(vacancyToAdd);
            uow.Commit();
            return DTOService.ToDTO<Vacancy, VacancyDTO>(vacancyToAdd);
        }
        public void Delete(int id)
        {
            var vacancyToDelete = uow.VacancyRepo.GetByID(id);
            if(vacancyToDelete==null)
            {
                throw new EntityNotFoundException("Vacancy not found");
            }
            uow.VacancyRepo.Delete(id);
            uow.Commit();
        }
    }
}