﻿using System.Web;
using System.Web.Mvc;

namespace MVCDay2Learn
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}