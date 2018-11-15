using System;
using System.Collections.Generic;

namespace FlowerShop.Models.Views
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public ICollection<ProductViewModel> Product { get; set; }
    }
}
