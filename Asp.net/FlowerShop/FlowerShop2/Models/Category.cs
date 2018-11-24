using System;
using System.Collections.Generic;

namespace FlowerShop2.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        
    }
}
