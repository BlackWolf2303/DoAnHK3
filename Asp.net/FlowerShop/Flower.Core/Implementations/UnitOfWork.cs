using Flower.Core.Entities;
using Flower.Core.Interfaces;
using System;
using System.Data.Entity;

namespace Flower.Core.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FlowerDbContext context;

        private IRepository<Category> categoryRepository;
        private IRepository<Discount> discountRepository;
        private IRepository<Image> imageRepository;
        private IRepository<Order> orderRepository;
        private IRepository<OrderDetail> orderDetailRepository;
        private IRepository<Product> productRepository;
        private IRepository<Role> roleRepository;
        private IRepository<User> userRepository;

        public UnitOfWork(FlowerDbContext context)
        {
            this.context = context;
        }

        public IRepository<Product> ProductRepository
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new Repository<Product>(context);
                }
                return productRepository;
            }
        }

        public IRepository<Category> CategoryRepository {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new Repository<Category>(context);
                }
                return categoryRepository;
            }
        }

        public void Refresh()
        {
            context.Rollback();
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
