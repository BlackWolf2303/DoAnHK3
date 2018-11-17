using Flower.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Flower.Core.Interfaces
{
    public interface IRepository<T> where T: Entity
    {
        IQueryable<T> Entities { get; }

        void Create(T entity);

        void Edit(T entity);

        IQueryable<T> GetAll();

        T Get(params object[] keyValues);

        IQueryable<T> Get(Expression<Func<T, bool>> predicate);

        void Delete(params object[] keyValues);

        int Delete(Expression<Func<T, bool>> predicate);
    }
}
