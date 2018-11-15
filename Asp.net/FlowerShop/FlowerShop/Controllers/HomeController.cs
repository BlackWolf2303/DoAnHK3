using FlowerShop.DAL;
using FlowerShop.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HomeServices homeServices = new HomeServices();
            var product = AutoMapper.Mapper.Map<List<ProductViewModel>>(homeServices.GetAll());
            return View(product);
        }
    }
}