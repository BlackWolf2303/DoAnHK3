using AutoMapper;
using Flower.Core.Implementations;
using Flower.Core.Interfaces;
using FlowerShop.Models.Views;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerShop.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork unitOfWork;
        public HomeController()
        {
            unitOfWork = new UnitOfWork(new FlowerDbContext());
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HomeList(int? listType)
        {
            var products = Mapper.Map<List<ProductViewModel>>(unitOfWork.ProductRepository.GetAll().ToList());
            switch (listType)
            {
                case 1:
                    products = products.OrderByDescending(p => p.OrderDetails.Count).Take(4).ToList();
                    break;
                case 2:
                    products = products.OrderBy(p => p.Created).Take(4).ToList();
                    break;
                default:
                    break;
            }
            return PartialView(products);
        }

        #region TestAjax
        public ActionResult PartialViewWithAjax()
        {
            var model = GetFullAndPartialViewModel();
            ViewBag.Catetories = model.CategoryList;
            ViewBag.Products = model.Products;
            return View(model);
        }

        private FullAndPartialViewModel GetFullAndPartialViewModel(int categoryId = 1)
        {
            //... code omitted...
            // populate the viewModel and return it
            var fullAndPartialViewModel = new FullAndPartialViewModel();

            var listView = new List<FullAndPartialViewModel>
            {
                new FullAndPartialViewModel
                {
                    CategoryId = 1,
                    CategoryList = new List<CategoryListItem>
                    {
                        new CategoryListItem {CategoryId= 1, CategoryName ="Category 1"},
                        new CategoryListItem {CategoryId= 2, CategoryName ="Category 2"}
                    },
                    Products = new List<CategoryProductItem>
                    {
                        new CategoryProductItem {CategoryId = 1,Product ="Product 1"},
                        new CategoryProductItem {CategoryId = 2,Product ="Product 2"},
                    }
                },
                new FullAndPartialViewModel
                {
                    CategoryId = 2,
                    CategoryList = new List<CategoryListItem>
                    {
                        new CategoryListItem {CategoryId= 4, CategoryName ="Category 3"},
                        new CategoryListItem {CategoryId= 3, CategoryName ="Category 4"}
                    },
                    Products = new List<CategoryProductItem>
                    {
                        new CategoryProductItem {CategoryId = 3,Product ="Product 3"},
                        new CategoryProductItem {CategoryId = 4,Product ="Product 4"},
                    }
                }
            };

            foreach (var item in listView)
            {
                if (item.CategoryId == categoryId)
                {
                    fullAndPartialViewModel = item;
                }
            }

            return fullAndPartialViewModel;
        }

        [HttpGet]
        public ActionResult GetCategoryProducts(string categoryId)
        {
            var lookupId = int.Parse(categoryId);
            var model = GetFullAndPartialViewModel(lookupId).Products;
            return PartialView("CategoryResults", model);
        }
        #endregion
    }
}