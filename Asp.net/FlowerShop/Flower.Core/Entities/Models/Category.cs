using System;
using System.Collections.Generic;

namespace Flower.Core.Entities
{
    public class Category : BaseEntity, ILogicalDeleteEntity
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

        public ICollection<Product> Product { get; set; }
        
    }
}
