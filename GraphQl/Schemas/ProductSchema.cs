using GraphQL.Types;
using GraphQlTest.Mutations;
using GraphQlTest.Queries;

namespace GraphQlTest.Schemas
{
    public class ProductSchema : Schema
    {
        public ProductSchema(ProductQuery productQuery, ProductMutation productMutation)
        {
            Query = productQuery;
            Mutation = productMutation;
        }
    }
}
