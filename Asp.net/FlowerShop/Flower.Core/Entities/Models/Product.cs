using System;
using System.Collections.Generic;

namespace Flower.Core.Entities
{
    public class Product : BaseEntity, ILogicalDeleteEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Stock { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
