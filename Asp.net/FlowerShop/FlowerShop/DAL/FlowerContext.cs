using FlowerShop.Models;
using System.Data.Entity;

namespace FlowerShop.DAL
{
    public class FlowerContext : DbContext
    {
        public FlowerContext() : base("FlowerShopContext")
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
