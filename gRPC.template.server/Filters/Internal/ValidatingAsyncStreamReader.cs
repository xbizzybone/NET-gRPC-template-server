﻿namespace gRPC.template.server.Filters.Internal;

internal class ValidatingAsyncStreamReader<TRequest> : IAsyncStreamReader<TRequest>
{
    private readonly IAsyncStreamReader<TRequest> _innerReader;
    private readonly Func<TRequest, Task> _validator;

    public ValidatingAsyncStreamReader(IAsyncStreamReader<TRequest> innerReader, Func<TRequest, Task> validator)
    {
        _innerReader = innerReader;
        _validator = validator;
    }

    public async Task<bool> MoveNext(CancellationToken cancellationToken)
    {
        var success = await _innerReader.MoveNext(cancellationToken).ConfigureAwait(false);
        if (success)
        {
            await _validator.Invoke(Current).ConfigureAwait(false);
        }

        return success;
    }

    public TRequest Current => _innerReader.Current;
}
