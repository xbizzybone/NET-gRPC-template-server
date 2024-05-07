using FluentValidation;

namespace gRPC.template.server.Validators
{
    public class BookRequestValidator : AbstractValidator<BookRequest>
    {
        public BookRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Author).NotEmpty();
            RuleFor(x => x.Price).NotEmpty();
            RuleFor(x => x.Category).NotEmpty();
        }
    }
}
