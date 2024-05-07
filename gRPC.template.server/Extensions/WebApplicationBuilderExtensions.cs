namespace gRPC.template.server.Extensions;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder ConfigureApplicationBuilder(this WebApplicationBuilder builder)
    {
        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .Enrich.WithThreadId()
            .Enrich.WithThreadName()
            .Enrich.WithMachineName()
            .Enrich.WithEnvironmentName()
            .WriteTo.Console()
            .CreateLogger();

        _ = builder.Logging.ClearProviders();
        _ = builder.Logging.AddSerilog(Log.Logger);
        _ = builder.Services.AddGrpc(options => options.EnableMessageValidation());
        _ = builder.Services.AddObjectsValidators();
        //_ = builder.Services.AddValidators();
        _ = builder.Services.AddGrpcValidation();

        _ = builder.Services.Configure<BookStoreDatabaseSettings>(builder.Configuration.GetSection("BookStoreDatabase"));

        _ = builder.Services.AddDependencies();

        return builder;
    }

    private static IServiceCollection AddObjectsValidators(this IServiceCollection services)
    {
        _ = services.AddValidator<CreateBookRequestValidator>();
        _ = services.AddValidator<UpdateBookRequestValidator>();

        return services;
    }

    private static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        _ = services.AddScoped<IBookService, BookService>();
        _ = services.AddScoped<IBookRepository, BookRepository>();

        return services;
    }
}
