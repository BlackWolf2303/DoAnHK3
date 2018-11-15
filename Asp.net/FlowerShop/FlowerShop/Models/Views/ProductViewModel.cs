using System;
using System.Collections.Generic;

namespace FlowerShop.Models.Views
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Stock { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<OrderDetailViewModel> OrderDetails { get; set; }
        public ICollection<ImageViewModel> Images { get; set; }
    }
}
