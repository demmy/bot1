using System.Data.Entity;
using Data.Infrastructure;
using Domain.Entities;
using BaseOfTalents.DAL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DAL.DTO;

namespace BaseOfTalents.DAL.Repositories
{
    public class VacancyRepository : BaseRepository<Vacancy>, IVacancyRepository
    {
        public VacancyRepository(DbContext context) : base(context)
        {
        }

        public override IEnumerable<Vacancy> Get(Expression<Func<Vacancy, bool>> filter = null, Func<IQueryable<Vacancy>, IOrderedQueryable<Vacancy>> orderBy = null, string includeProperties = "", int page = 1, int pageSize = 20)
        {
            return base.Get(filter, orderBy, includeProperties, page, pageSize)
                .Skip(page * pageSize)
                .Take(pageSize);
        }
    }
}