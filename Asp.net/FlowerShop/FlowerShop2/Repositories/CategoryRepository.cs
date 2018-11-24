using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlowerShop2.Models;

namespace FlowerShop2.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private FlowerContext db = new FlowerContext();

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }
    }
}