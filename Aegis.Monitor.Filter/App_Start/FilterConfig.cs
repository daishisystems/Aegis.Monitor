﻿using System.Web;
using System.Web.Mvc;

namespace Aegis.Monitor.Filter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}