using System;
using System.Collections.Generic;

namespace Flower.Core.Entities
{
    public class Order : BaseEntity, ILogicalDeleteEntity
    {
        public double Total { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int DiscountId { get; set; }
        public Discount Discount { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
