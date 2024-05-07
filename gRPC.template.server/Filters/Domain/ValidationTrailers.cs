namespace gRPC.template.server.Filters.Domain;

[MemoryPackable]
public partial class ValidationTrailers
{
    public string PropertyName { get; set; }

    public string ErrorMessage { get; set; }

    public string AttemptedValue { get; set; }
}
