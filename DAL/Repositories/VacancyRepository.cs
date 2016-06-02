using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DAL.Infrastructure;
using Domain.Entities;

namespace DAL.Repositories
{
    public class VacancyRepository : BaseRepository<Vacancy>, IVacancyRepository
    {
        public VacancyRepository(DbContext context) : base(context)
        {
        }

        public override IEnumerable<Vacancy> Get(Expression<Func<Vacancy, bool>> filter = null,
            Func<IQueryable<Vacancy>, IOrderedQueryable<Vacancy>> orderBy = null, string includeProperties = "",
            int page = 1, int pageSize = 20)
        {
            return base.Get(filter, orderBy, includeProperties, page, pageSize)
                .Skip(page*pageSize)
                .Take(pageSize);
        }
    }
}