﻿using System.Web;
using System.Web.Mvc;

namespace _23dh111859_KtraFe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
