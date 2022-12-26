using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQlTest.Queries;
using GraphQlTest.Schemas;
using GraphQlTest.Services;
using GraphQlTest.Services.Interfaces;
using GraphQlTest.Types;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IProductService, ProductService>();
            builder.Services.AddSingleton<ProductType>();
            builder.Services.AddSingleton<ProductQuery>();
            builder.Services.AddSingleton<ISchema, ProductSchema>();
            builder.Services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            }).AddSystemTextJson();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseHttpsRedirection();

            //app.UseAuthorization();

            //app.MapControllers();

            app.UseGraphiQl("/graphQL");
            app.UseGraphQL<ISchema>();

            app.Run();
        }
    }
}