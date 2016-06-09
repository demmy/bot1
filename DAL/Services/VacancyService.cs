﻿using BaseOfTalents.DAL.Infrastructure;
using BaseOfTalents.Domain.Entities;
using DAL.Extensions;
using Domain.DTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Services
{
    public partial class VacancyService 
    {
        IUnitOfWork uow;
        public VacancyService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public VacancyDTO Get(int id)
        {
            var entity = uow.VacancyRepo.GetByID(id);
            return DTOService.ToDTO<Vacancy, VacancyDTO>(entity);
        }

        public Tuple<IEnumerable<VacancyDTO>, int> Get(
            int? userId,
            int? industryId,
            string title,
            int? state,
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
            if (state.HasValue)
            {
                filters.Add(x => (int)x.State == state);
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

        public bool Delete(int id)
        {
            bool deleteResult;
            var entityToDelete = uow.VacancyRepo.GetByID(id);
            if (entityToDelete == null)
            {
                deleteResult = false;
            }
            else {
                uow.VacancyRepo.Delete(id);
                uow.Commit();
                deleteResult = true;
            }
            return deleteResult;
        }

    }
}