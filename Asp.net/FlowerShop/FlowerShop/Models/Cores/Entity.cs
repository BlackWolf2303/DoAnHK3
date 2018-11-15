using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop.Models.Cores
{
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public T Id { get; set; }
    }

    public abstract class BaseEntity
    {

    }
}
