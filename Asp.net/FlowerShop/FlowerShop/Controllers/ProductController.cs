using AutoMapper;
using Flower.Core.Entities;
using Flower.Core.Implementations;
using Flower.Core.Interfaces;
using FlowerShop.Models.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerShop.Controllers
{
    public class ProductController : Controller
    {
        protected IUnitOfWork unitOfWork;
        public ProductController()
        {
            unitOfWork = new UnitOfWork(new FlowerDbContext());
        }

        #region Woking
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HeaderBottomLeft()
        {
            var products = new List<ProductViewModel>
            {
                new ProductViewModel{Name = "Rose", Price = 300, Description = "Description 1",
                    Images = new List<ImageViewModel>{ new ImageViewModel{ Path = "pic4.png" } } },
                new ProductViewModel{Name = "Sun Flower", Price = 300, Description = "Description 2",
                    Images = new List<ImageViewModel>{ new ImageViewModel{ Path = "pic4.png" } } },
                new ProductViewModel{Name = "Apricot blossom", Price = 300, Description = "Description 3",
                    Images = new List<ImageViewModel>{ new ImageViewModel{ Path = "pic4.png" } } },
                new ProductViewModel{Name = "Sakura", Price = 300, Description = "Description 4",
                    Images = new List<ImageViewModel>{ new ImageViewModel{ Path = "pic4.png" } } }
            };
            return PartialView(products);
        }

        public ActionResult HeaderBottomRight()
        {
            var images = new List<ImageViewModel>
            {
                new ImageViewModel { Path = "1.jpg" },
                new ImageViewModel { Path = "2.jpg" },
                new ImageViewModel { Path = "3.jpg" },
                new ImageViewModel { Path = "4.jpg" }
            };
            return PartialView(images);
        }

        public ActionResult ProductList(int sort = (int)SortBy.Ascending, int show = (int)Show.Four, int currentPage = 1)
        {
            #region TempData
            //var products = new List<ProductViewModel>
            //{
            //    new ProductViewModel{Name = "Rose", Price = 100, Description = "Description 1",
            //        Images = new List<ImageViewModel>{ new ImageViewModel{ Path = "pic4.png" } } },
            //    new ProductViewModel{Name = "Sun Flower", Price = 500, Description = "Description 2",
            //        Images = new List<ImageViewModel>{ new ImageViewModel{ Path = "pic4.png" } } },
            //    new ProductViewModel{Name = "Apricot blossom", Price = 700, Description = "Description 3",
            //        Images = new List<ImageViewModel>{ new ImageViewModel{ Path = "pic4.png" } } },
            //    new ProductViewModel{Name = "Sakura", Price = 300, Description = "Description 4",
            //        Images = new List<ImageViewModel>{ new ImageViewModel{ Path = "pic4.png" } } },
            //    new ProductViewModel{Name = "Rose", Price = 900, Description = "Description 5",
            //        Images = new List<ImageViewModel>{ new ImageViewModel{ Path = "pic4.png" } } },
            //    new ProductViewModel{Name = "Sun Flower", Price = 200, Description = "Description 6",
            //        Images = new List<ImageViewModel>{ new ImageViewModel{ Path = "pic4.png" } } },
            //    new ProductViewModel{Name = "Apricot blossom", Price = 400, Description = "Description 7",
            //        Images = new List<ImageViewModel>{ new ImageViewModel{ Path = "pic4.png" } } },
            //    new ProductViewModel{Name = "Sakura", Price = 500, Description = "Description 8",
            //        Images = new List<ImageViewModel>{ new ImageViewModel{ Path = "pic4.png" } } }
            //};
            #endregion

            var products = Mapper.Map<List<ProductViewModel>>(unitOfWork.ProductRepository.GetAll());

            switch (sort)
            {
                case (int)SortBy.Ascending:
                    products = products.OrderBy(o => o.Price).ToList();
                    break;
                case (int)SortBy.Descending:
                    products = products.OrderByDescending(o => o.Price).ToList();
                    break;
                default:
                    break;
            }

            //products = products.Take(show).ToList();
            var proCurrentPage = new List<ProductViewModel>();
            var count = ((currentPage - 1) * show + show) > products.Count ? products.Count - ((currentPage - 1) * show) : show;
            for (int i = 0; i < count; i++)
            {
                proCurrentPage.Add(products.ElementAt((currentPage - 1) * show + i));
            }

            return PartialView(proCurrentPage);
        }
        #endregion

        #region CRUD
        // GET: Product
        public string GetAll()
        //public IEnumerable<Product> Get()
        {
            return JsonConvert.SerializeObject(unitOfWork.ProductRepository.GetAll());
        }

        // GET: Product/5
        public Product Get(int id)
        {
            return unitOfWork.ProductRepository.Get(id);
        }

        // POST: Product
        public void Post(Product value)
        {
            unitOfWork.ProductRepository.Create(value);
            unitOfWork.Commit();
        }

        // PUT: Product/5
        public void Put(int id, string value)
        {
            //unit
        }

        // DELETE: Product/5
        public void Delete(int id)
        {
        }
        #endregion

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}