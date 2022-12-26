using GraphQl.Models;
using GraphQlTest.Services.Interfaces;

namespace GraphQlTest.Services
{
    public class ProductService : IProductService
    {
        private List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "p1", Price = 20 },
            new Product { Id = 2, Name = "p2", Price = 20 }
        };

        public Product AddProduct(Product product)
        {
            _products.Add(product);
            return product;
        }

        public Product DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            if(product != null)
                _products.Remove(product);
            return product;
        }

        public List<Product> GetAllProducts()
        {
           return _products;
        }

        public Product GetProduct(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public Product UpdateProduct(int id, Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
                throw new Exception("Not correct id");

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;

            return existingProduct;
        }
    }
}
