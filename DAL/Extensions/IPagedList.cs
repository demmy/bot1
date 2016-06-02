using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseOfTalents.DAL.Extensions
{
    public interface IPagedList
    {
        int PageIndex { get; }

        int PageSize { get; }

        int TotalCount { get; }

        IList List { get; }
    }

    public interface IPagedList<T> : IPagedList
    {
        new IList<T> List { get; }
    }
}
