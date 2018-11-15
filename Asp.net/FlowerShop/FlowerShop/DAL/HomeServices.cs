using FlowerShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowerShop.DAL
{
    public class HomeServices
    {
        // best seller
        // special product
        // new product
        // category
        public FlowerContext _db;

        public HomeServices()
        {
            _db = new FlowerContext();
        }

        public List<Product> GetAll()
        {
            return _db.Products.Include("Images").ToList();
        }
    }
}