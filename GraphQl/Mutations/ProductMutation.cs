using GraphQl.Models;
using GraphQL;
using GraphQL.Types;
using GraphQlTest.Services.Interfaces;
using GraphQlTest.Types;

namespace GraphQlTest.Mutations
{
    public class ProductMutation : ObjectGraphType
    {
        public ProductMutation(IProductService productService)
        {
            Field<ProductType>("createProduct", 
                arguments: new QueryArguments(new QueryArgument<ProductInputType> { Name = "product" }),
                resolve: context => { return productService.AddProduct(context.GetArgument<Product>("product")); });
            Field<ProductType>("updateProduct",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }, new QueryArgument<ProductInputType> { Name = "product" }),
                resolve: context => { return productService.UpdateProduct(context.GetArgument<int>("id"), context.GetArgument<Product>("product")); });
        }
    }
}
