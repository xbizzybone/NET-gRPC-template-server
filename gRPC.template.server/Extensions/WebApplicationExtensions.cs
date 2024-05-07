namespace gRPC.template.server.Extensions;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static class WebApplicationExtensions
{
    public static WebApplication ConfigureApplication(this WebApplication app)
    {
        _ = app.UseRouting();

        // Configure the HTTP request pipeline.
        _ = app.MapGrpcService<BooksService>();

        _ = app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

        return app;
    }
}
