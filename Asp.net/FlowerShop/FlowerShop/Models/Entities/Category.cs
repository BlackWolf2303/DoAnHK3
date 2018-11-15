using System;
using System.Collections.Generic;

namespace FlowerShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
