using FlowerShop2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerShop2.Controllers
{
    public class ProductController : Controller
    {
        private ICategoryRepository categoryRepository = new CategoryRepository();
        public ActionResult Category(int id)
        {
            var category = categoryRepository.Get(id);
            ViewBag.Category = category;
            ViewBag.Products = category.Products.ToList();
            var image = category.Products.ToList().FirstOrDefault().Images.FirstOrDefault();
            return View("Category");
        }

        public ActionResult Specials()
        {
            return View("Specials");
        }

        public ActionResult Details()
        {
            return View("Details");
        }
    }
}