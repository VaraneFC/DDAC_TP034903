﻿using System.Web;
using System.Web.Mvc;

namespace DDAC_TP034903
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
