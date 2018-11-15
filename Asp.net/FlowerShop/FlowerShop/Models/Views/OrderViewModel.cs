using System;
using System.Collections.Generic;

namespace FlowerShop.Models.Views
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public int UserId { get; set; }
        public UserViewModel User { get; set; }

        public int DiscountId { get; set; }
        public DiscountViewModel Discount { get; set; }

        public ICollection<OrderDetailViewModel> OrderDetails { get; set; }
    }
}
