using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("ConnectionString:DefaultConnection"));
            var database = client.GetDatabase(configuration.GetValue<string>("ConnectionString:DatabaseName"));

            Products = database.GetCollection<Product>(configuration.GetValue<string>("ConnectionString:CollectionName"));

            CatalogContextSeed.SeedData(Products);

        }

        public IMongoCollection<Product> Products { get; }
    }
}

  
