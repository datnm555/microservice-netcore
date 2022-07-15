using Catalog.Api.Data;
using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Repository
{
    public class ProductRepository : IProductRepository
    {

        private readonly ICatalogContext _context;

        public ProductRepository(ICatalogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public Task<Product> CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductById(string id)
        {
            return await _context.Products.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.Find(x=>true).ToListAsync();
        }

        public Task<IEnumerable<Product>> GetProductsByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
