using GraphQl.Models;
using GraphQlTest.Services.Interfaces;

namespace GraphQlTest.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "p1", Price = 20 },
            new Product { Id = 2, Name = "p2", Price = 20 }
        };
        public List<Product> GetAllProducts()
        {
           return _products;
        }

        public Product GetProduct(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
