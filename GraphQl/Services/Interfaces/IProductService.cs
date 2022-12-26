using GraphQl.Models;

namespace GraphQlTest.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProduct(int id);
    }
}
