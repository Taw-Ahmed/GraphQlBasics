using GraphQL;
using GraphQL.Types;
using GraphQlTest.Services.Interfaces;
using GraphQlTest.Types;

namespace GraphQlTest.Queries
{
    public class ProductQuery : ObjectGraphType
    {
        private readonly IProductService _productService;

        public ProductQuery(IProductService productService)
        {
            this._productService = productService;

            Field<ListGraphType<ProductType>>("products", resolve: context => { return _productService.GetAllProducts(); });
            Field<ProductType>("product",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => { return _productService.GetProduct(context.GetArgument<int>("id")); }
               );
        }
    }
}
