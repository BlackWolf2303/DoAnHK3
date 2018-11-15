using System;
using System.Collections.Generic;

namespace FlowerShop.Models.Views
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public int RoleId { get; set; }
        public RoleViewModel Role { get; set; }

        public ICollection<OrderViewModel> Orders { get; set; }
    }
}
