using System;
using System.Collections.Generic;

namespace FlowerShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int DiscountId { get; set; }
        public Discount Discount { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
