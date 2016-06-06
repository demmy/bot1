using BaseOfTalents.DAL.Infrastructure;
using BaseOfTalents.Domain.Entities;
using DAL.Extensions;
using Domain.DTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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

        public IEnumerable<VacancyDTO> Get(
            int? userId,
            int? industryId, 
            string title, 
            int? vacancyState,
            int? typeOfEmployment,
            IEnumerable<int> levelIds,
            IEnumerable<int> locationIds,
            int current, 
            int size)
        {
            var filters = new List<Expression<Func<Vacancy, bool>>>();

            if(userId.HasValue)
            {
                filters.Add(x => x.ResponsibleId == userId);
            }
            if(industryId.HasValue)
            {
                filters.Add(x => x.IndustryId == industryId);
            }
            if(!String.IsNullOrEmpty(title)) 
            {
                filters.Add(x => x.Title.StartsWith(title));
            }
            if(vacancyState.HasValue)
            {
                filters.Add(x => (int) x.State == vacancyState);
            }
            if(typeOfEmployment.HasValue)
            {
                filters.Add(x => (int)x.TypeOfEmployment == typeOfEmployment);
            }
            if(levelIds.Any())
            {
                filters.Add(x => x.Levels.Any(l => levelIds.Contains(l.Id)));
            }
            if(locationIds.Any())
            {
                filters.Add(x => x.Locations.Any(loc => locationIds.Contains(loc.Id)));
            }
            var www = uow.VacancyRepo.Get(filters, page: current, pageSize: size);
            return null;
        }


    }
}