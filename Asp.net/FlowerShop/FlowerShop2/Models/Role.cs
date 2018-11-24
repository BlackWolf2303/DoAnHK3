using System;
using System.Collections.Generic;

namespace FlowerShop2.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
