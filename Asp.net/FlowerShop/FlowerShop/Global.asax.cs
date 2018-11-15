using AutoMapper;
using FlowerShop.Models;
using FlowerShop.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FlowerShop
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Model Mappers
            Mapper.Initialize(cfg => {
                // db to viewB
                cfg.CreateMap<Category, CategoryViewModel>();
                cfg.CreateMap<Discount, DiscountViewModel>();
                cfg.CreateMap<Image, ImageViewModel>();
                cfg.CreateMap<Order, OrderViewModel>();
                cfg.CreateMap<OrderDetail, OrderDetailViewModel>();
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<Role, RoleViewModel>();
                cfg.CreateMap<User, UserViewModel>();
                // view to db
                cfg.CreateMap<CategoryViewModel, Category>();
                cfg.CreateMap<DiscountViewModel, Discount>();
                cfg.CreateMap<ImageViewModel, Image>();
                cfg.CreateMap<OrderViewModel, Order>();
                cfg.CreateMap<OrderDetailViewModel, OrderDetail>();
                cfg.CreateMap<ProductViewModel, Product>();
                cfg.CreateMap<RoleViewModel, Role>();
                cfg.CreateMap<UserViewModel, User>();
            });
        }
        protected void Session_Start()
    {
      Session["userid"] = null;
      Session["username"] = null;
      Session["fullname"] = null;
      Session["avatar"] = null;
    }
    }
}
