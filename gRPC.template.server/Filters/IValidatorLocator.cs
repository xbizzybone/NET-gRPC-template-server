namespace gRPC.template.server.Filters;

public interface IValidatorLocator
{
    bool TryGetValidator<TRequest>(out IValidator<TRequest> result) where TRequest : class;
}
