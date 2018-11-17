using Flower.Core.Entities;
using Flower.Core.Interfaces;

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

        public IRepository<User> UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new Repository<User>(context);
                }
                return userRepository;
            }
        }

        public IRepository<Role> RoleRepository
        {
            get
            {
                if (roleRepository == null)
                {
                    roleRepository = new Repository<Role>(context);
                }
                return roleRepository;
            }
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

        public IRepository<OrderDetail> OrderDetailRepository
        {
            get
            {
                if (orderDetailRepository == null)
                {
                    orderDetailRepository = new Repository<OrderDetail>(context);
                }
                return orderDetailRepository;
            }
        }

        public IRepository<Order> OrderRepository
        {
            get
            {
                if (orderRepository == null)
                {
                    orderRepository = new Repository<Order>(context);
                }
                return orderRepository;
            }
        }

        public IRepository<Image> ImageRepository
        {
            get
            {
                if (imageRepository == null)
                {
                    imageRepository = new Repository<Image>(context);
                }
                return imageRepository;
            }
        }

        public IRepository<Discount> DiscountRepository
        {
            get
            {
                if (discountRepository == null)
                {
                    discountRepository = new Repository<Discount>(context);
                }
                return discountRepository;
            }
        }

        public IRepository<Category> CategoryRepository
        {
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
