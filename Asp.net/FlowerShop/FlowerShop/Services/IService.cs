using FlowerShop.Models.Cores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Services
{
    public interface IService<T>
    {
        void Create(T entity);

        void Edit(T entity);

        IList<T> GetAll();

        T Get(params object[] keyValues);

        void Delete(params object[] keyValues);
    }
}
