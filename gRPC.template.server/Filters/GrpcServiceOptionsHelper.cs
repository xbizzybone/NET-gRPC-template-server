namespace gRPC.template.server.Filters;

public static class GrpcServiceOptionsHelper
{
    public static GrpcServiceOptions EnableMessageValidation(this GrpcServiceOptions options)
    {
        options.Interceptors.Add<ValidationInterceptor>();
        return options;
    }
}