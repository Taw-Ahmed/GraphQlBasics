using GraphQl.Models;
using GraphQL.Types;

namespace GraphQlTest.Types
{
    public class ProductType :ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Price);

        }
    }
}
