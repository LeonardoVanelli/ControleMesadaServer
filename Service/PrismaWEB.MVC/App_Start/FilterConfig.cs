﻿using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Atributos.RotaPersonAttribute());
        }
    }
}
