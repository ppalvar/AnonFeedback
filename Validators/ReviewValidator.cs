namespace Validators;

using Dtos.Incoming;
using FluentValidation;

public class ReviewValidator : AbstractValidator<NewReviewRequest>
{
    public ReviewValidator()
    {
        RuleFor(rev => rev.Score)
            .Must(score => (score >= 0) && (score <= 10))
                .WithMessage("Score must be in 0-10 range");

        RuleFor(rev => rev.Comment)
            .NotEmpty()
                .WithMessage("The comment cannot be empty");
    }
}