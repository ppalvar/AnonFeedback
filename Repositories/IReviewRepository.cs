namespace Repositories;

using Models;

public interface IReviewRepository
{
    public Task<IEnumerable<Review>> GetReviews(int productId);
    public void CreateReview(Review review);
}