using Models;

namespace Repositories;

public interface IProductRepository
{
    public Task<IEnumerable<Product>> GetList();
    public Task<Product?> GetDetail(int id);
}