﻿using System.Web;
using System.Web.Mvc;

namespace MAP_K0_API_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
