using System;
using System.Collections.Generic;

namespace Flower.Core.Entities
{
    public class Discount : BaseEntity, ILogicalDeleteEntity
    {
        public string Name { get; set; }
        public int Percent { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
