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
            var sortList = new Dictionary<int, string>();
            foreach (var item in Enum.GetValues(typeof(SortBy)))
            {
                sortList.Add((int)item, item.ToString());
            }

            var showList = new Dictionary<int, string>();
            foreach (var item in Enum.GetValues(typeof(Show)))
            {
                showList.Add((int)item, item.ToString());
            }

            ViewBag.SortList = sortList;
            ViewBag.ShowList = showList;
            ViewBag.Sort = (int)SortBy.Ascending;
            ViewBag.Show = (int)Show.Four;
            ViewBag.CurrentPage = 1;
            //ViewBag.CurrentPage = sortList.;

            return View();
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