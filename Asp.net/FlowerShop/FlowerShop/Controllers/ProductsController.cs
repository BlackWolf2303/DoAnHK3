using FlowerShop.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerShop.Controllers
{
    public class ProductsController : Controller
    {
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

        public ActionResult ProductList()
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
    }
}