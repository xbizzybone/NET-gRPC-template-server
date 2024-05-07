namespace gRPC.template.server.Filters.Internal;

internal static class MetadataExtensions
{
    public static Metadata ToValidationMetadata(this IList<ValidationFailure> failures)
    {
        var metadata = new Metadata();
        if (failures.Any())
        {
            metadata.Add(new Metadata.Entry("validation-errors-text", failures.ToValidationTrailers().ToBase64()));
        }
        return metadata;
    }
}
