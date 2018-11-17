using Flower.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Product> ProductRepository { get; }

        IRepository<Category> CategoryRepository { get; }

        void Refresh();

        void Commit();
    }
}
