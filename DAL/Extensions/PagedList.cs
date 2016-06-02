﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseOfTalents.DAL.Extensions
{
    public class PagedList<T> : IPagedList<T>
    {
        public PagedList(
            IList<T> list,
            int pageIndex,
            int pageSize,
            int totalCount)
        {
            List = list;
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
        }

        public int PageIndex { get; private set; }

        public int PageSize { get; private set; }

        public int TotalCount { get; private set; }

        public IList<T> List { get; private set; }

        IList IPagedList.List
        {
            get { return (IList)List; }
        }
    }
}