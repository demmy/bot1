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
            Expression<Func<Vacancy, bool>> filter = v => true;
            if(userId.HasValue)
            {
                filter = filter.AndAlso(x => x.ResponsibleId == userId);
            }
            if(industryId.HasValue)
            {
                filter = filter.AndAlso(x => x.IndustryId == industryId);
            }
            if(!String.IsNullOrEmpty(title)) 
            {
                filter = filter.AndAlso(x => x.Title.StartsWith(title));
            }
            if(vacancyState.HasValue)
            {
                filter = filter.AndAlso(x => (int) x.State == vacancyState);
            }
            if(typeOfEmployment.HasValue)
            {
                filter = filter.AndAlso(x => (int)x.TypeOfEmployment == typeOfEmployment);
            }
            if(levelIds.Any())
            {
                filter = filter.AndAlso(x => x.Levels.Any(l => levelIds.Contains(l.Id)));
            }
            if(locationIds.Any())
            {
                filter = filter.AndAlso(x => x.Locations.Any(loc => locationIds.Contains(loc.Id)));
            }
            var www = uow.VacancyRepo.Get(filter, page: current, pageSize: size);
            return null;
        }


    }
}