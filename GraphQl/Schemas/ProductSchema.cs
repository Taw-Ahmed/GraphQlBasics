using GraphQL.Types;
using GraphQlTest.Queries;

namespace GraphQlTest.Schemas
{
    public class ProductSchema : Schema
    {
        public ProductSchema(ProductQuery productQuery)
        {
            Query = productQuery;
        }
    }
}
