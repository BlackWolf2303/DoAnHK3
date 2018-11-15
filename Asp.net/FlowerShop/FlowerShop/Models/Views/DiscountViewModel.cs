using System;
using System.Collections.Generic;

namespace FlowerShop.Models.Views
{
    public class DiscountViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public ICollection<OrderViewModel> Orders { get; set; }
    }
}
