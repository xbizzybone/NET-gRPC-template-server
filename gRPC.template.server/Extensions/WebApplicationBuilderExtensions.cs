namespace gRPC.template.server.Extensions;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder ConfigureApplicationBuilder(this WebApplicationBuilder builder)
    {
        Log.Logger = LoggerConfig.GetConsoleLogger().CreateLogger();

        _ = builder.Logging.ClearProviders();
        _ = builder.Logging.AddSerilog(Log.Logger);
        _ = builder.Services.AddGrpc(options => options.EnableMessageValidation());

        _ = builder.Services.AddObjectsValidators();

        //_ = builder.Services.AddValidators();
        _ = builder.Services.AddGrpcValidation();

        return builder;
    }

    private static IServiceCollection AddObjectsValidators(this IServiceCollection services)
    {
        _ = services.AddValidator<BookRequestValidator>();

        return services;
    }
}
