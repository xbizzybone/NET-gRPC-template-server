using FluentValidation.Results;

namespace gRPC.template.server.Filters;

public interface IValidatorErrorMessageHandler
{
    Task<string> HandleAsync(IList<ValidationFailure> failures);
}
