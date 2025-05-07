using phuclien_company.Interfaces;
using phuclien_company.Models;

namespace phuclien_company.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<ProductModel> _products = FakeData.FakeData.Products;
        public Task AddAsync(ProductModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(BaseModel entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductModel>> GetAllAsync()
        {
            await Task.Delay(100);
            return _products;
        }

        public Task<ProductModel> GetByIdAsync(BaseModel entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProductModel entity)
        {
            throw new NotImplementedException();
        }
    }
}