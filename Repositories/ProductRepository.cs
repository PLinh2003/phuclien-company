using phuclien_company.Interfaces;
using phuclien_company.Models;

namespace phuclien_company.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly List<ProductModel> _products = FakeData.FakeData.Products;
    
    public Task AddAsync(ProductModel entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(ProductModel entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<ProductModel>> GetAllAsync()
    {
        await Task.Delay(100);
        return _products;
    }

    public async Task<ProductModel?> GetByIdAsync(ProductModel entity)
    {
        await Task.Delay(1);
        return _products.FirstOrDefault(p => p.Id == entity.Id);
    }

    public Task UpdateAsync(ProductModel entity)
    {
        throw new NotImplementedException();
    }
}