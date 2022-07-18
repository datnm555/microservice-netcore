using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(x => true).Any();
            if (!existProduct)
            {
                productCollection.InsertMany(GetPreconfigureProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfigureProducts()
        {
            return new List<Product>
            {
                new()
                {
                    Name = "Asus Laptop",
                    Category ="Computers",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile= "product-1.png",
                    Price = 511.93M
                },
                 new()
                {
                    Name = "Hp Laptop",
                    Category ="Computers",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile= "product-2.png",
                    Price = 424.93M
                },
                  new()
                {
                    Name = "Dell Laptop",
                    Category ="Computers",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile= "product-3.png",
                    Price = 32.93M
                }
            };
        }
    }
}