using System;

namespace FlowerShop2.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
