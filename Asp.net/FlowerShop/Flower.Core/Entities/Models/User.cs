using System;
using System.Collections.Generic;

namespace Flower.Core.Entities
{
    public class User : BaseEntity, ILogicalDeleteEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
