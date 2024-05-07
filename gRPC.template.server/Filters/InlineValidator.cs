using FluentValidation;

namespace gRPC.template.server.Filters;

public class InlineValidator<T> : AbstractValidator<T>
{
    public InlineValidator(Action<AbstractValidator<T>> configureRules)
    {
        configureRules(this);
    }
}
