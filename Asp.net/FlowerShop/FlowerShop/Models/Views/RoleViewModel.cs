using System;
using System.Collections.Generic;

namespace FlowerShop.Models.Views
{
    public class RoleViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public ICollection<UserViewModel> Users { get; set; }
    }
}
