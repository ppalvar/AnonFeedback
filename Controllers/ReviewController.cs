namespace Controllers;

using Repositories;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Dtos.Outgoing;
using Models;
using Dtos.Incoming;
using Validators;

[ApiController]
[Route("products")]
public class ReviewController : ControllerBase
{
    private readonly IReviewRepository _repo;
    private readonly IMapper _mapper;
    private readonly ReviewValidator _validator;

    public ReviewController(IMapper mapper, IReviewRepository repo, ReviewValidator validator)
    {
        _mapper = mapper;
        _repo = repo;
        _validator = validator;
    }

    [HttpGet("{productId}/feedback")]
    public async Task<IEnumerable<ReviewInfo>> GetReviews(int productId)
    {
        return _mapper.Map<IEnumerable<Review>, IEnumerable<ReviewInfo>>(await _repo.GetReviews(productId));
    }

    [HttpPost("{productId}/feedback")]
    public async Task<IActionResult> CreateReview(int productId, NewReviewRequest request) {
        request.ProductId = productId;

        var validatioResult = await _validator.ValidateAsync(request);

        if (!validatioResult.IsValid) {
            return BadRequest(validatioResult.Errors);
        }

        var _req = _mapper.Map<NewReviewRequest, Review>(request);
        _repo.CreateReview(_req);

        return NoContent();
    }
}