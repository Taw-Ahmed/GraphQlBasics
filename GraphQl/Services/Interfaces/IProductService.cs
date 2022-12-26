using GraphQl.Models;

namespace GraphQlTest.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProduct(int id);

        Product AddProduct(Product product);
        Product UpdateProduct(int id, Product product);

        Product DeleteProduct(int id);
    }
}
