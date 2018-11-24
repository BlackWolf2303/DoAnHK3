using System;
using System.Collections.Generic;

namespace FlowerShop2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

        public int DiscountId { get; set; }
        public virtual Discount Discount { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
