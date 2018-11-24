using FlowerShop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop2.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category Get(int id);
    }
}
