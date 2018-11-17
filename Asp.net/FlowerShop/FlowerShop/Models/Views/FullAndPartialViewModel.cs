using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowerShop.Models.Views
{
    public class FullAndPartialViewModel
    {
        public int CategoryId { get; set; }
        public List<CategoryProductItem> Products { get; set; }
        public List<CategoryListItem> CategoryList { get; set; }
    }

    public class CategoryListItem
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class CategoryProductItem
    {
        public int CategoryId { get; set; }
        public string Product { get; set; }
        public int Price { get; set; }
    }
}