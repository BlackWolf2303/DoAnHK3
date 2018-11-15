using System;
using System.Collections.Generic;

namespace FlowerShop.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
