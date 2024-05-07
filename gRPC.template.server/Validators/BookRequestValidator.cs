namespace gRPC.template.server.Validators;

public class CreateBookRequestValidator : AbstractValidator<CreateBookRequest>
{
    public CreateBookRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Author).NotEmpty();
        RuleFor(x => x.Price).NotEmpty();
        RuleFor(x => x.Category).NotEmpty();
    }
}

public class UpdateBookRequestValidator : AbstractValidator<UpdateBookRequest>
{
    public UpdateBookRequestValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Author).NotEmpty();
        RuleFor(x => x.Price).NotEmpty();
        RuleFor(x => x.Category).NotEmpty();
    }
}

public class BookIdentifierValidator : AbstractValidator<BookIdentifier>
{
    public BookIdentifierValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}