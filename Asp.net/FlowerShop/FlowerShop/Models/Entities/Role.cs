using System;
using System.Collections.Generic;

namespace FlowerShop.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
