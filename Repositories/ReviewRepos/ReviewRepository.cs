using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories;

public class ReviewRepository : IReviewRepository {
    private readonly AnonFeedbackDbContext _context;

    public ReviewRepository(AnonFeedbackDbContext context)
    {
        _context = context;
    }

    public async void CreateReview(Review review)
    {
        if (_context.Products.Any(prod => prod.Id == review.ProductId)) {
            await _context.Reviews.AddAsync(review);
            _context.SaveChanges();
        }
    }

    public async Task<IEnumerable<Review>> GetReviews(int productId)
    {
        return _context.Reviews.Where(review => review.ProductId == productId);
    }
}