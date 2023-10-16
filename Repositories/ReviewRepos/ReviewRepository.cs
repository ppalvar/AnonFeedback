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
        await _context.Reviews.AddAsync(review);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Review>> GetReviews(int productId)
    {
        return _context.Reviews.Where(review => review.ProductId == productId);
    }
}