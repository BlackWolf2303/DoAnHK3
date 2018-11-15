using System;

namespace FlowerShop.Models.Views
{
    public class OrderDetailViewModel
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public ProductViewModel Product { get; set; }
        public OrderViewModel Order { get; set; }
    }
}
