using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Models;

namespace FlowerShop2.Repositories
{
  public interface IProductRepository
  {
    List<Product> LastProducts(int n);
    List<Product> LatesProduct();
    List<Product> FeatureProducts(int n);
    List<Product> SprecialProducts();
    List<Product> RelatedProducts(Product product, int n);
    Product find(int id);
  }
}