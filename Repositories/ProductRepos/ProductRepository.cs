using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AnonFeedbackDbContext _context;

    public ProductRepository(AnonFeedbackDbContext context)
    {
        _context = context;
    }

    public async Task<Product?> GetDetail(int id)
    {
        return await _context.Products.Where(prod => prod.Id == id)
                                      .Include(prod => prod.Reviews)
                                      .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Product>> GetList()
    {
        return _context.Products.Include(prod => prod.Reviews);
    }
}