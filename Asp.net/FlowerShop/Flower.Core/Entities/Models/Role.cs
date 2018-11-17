using System;
using System.Collections.Generic;

namespace Flower.Core.Entities
{
    public class Role : BaseEntity, ILogicalDeleteEntity
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
