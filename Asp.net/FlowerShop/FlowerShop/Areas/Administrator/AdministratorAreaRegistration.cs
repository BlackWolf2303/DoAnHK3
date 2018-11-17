﻿using System.Web.Mvc;

namespace FlowerShop.Areas.Administrator
{
    public class AdministratorAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Administrator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Administrator/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}