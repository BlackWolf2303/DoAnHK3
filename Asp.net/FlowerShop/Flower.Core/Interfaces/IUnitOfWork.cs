using Flower.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Category> CategoryRepository { get; }
        IRepository<Discount> DiscountRepository { get; }
        IRepository<Image> ImageRepository { get; }
        IRepository<Order> OrderRepository { get; }
        IRepository<OrderDetail> OrderDetailRepository { get; }
        IRepository<Product> ProductRepository { get; }
        IRepository<Role> RoleRepository { get; }
        IRepository<User> UserRepository { get; }

        void Refresh();

        void Commit();
    }
}
