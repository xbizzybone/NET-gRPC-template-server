using gRPC.template.server.Extensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args).ConfigureApplicationBuilder();
var app = builder.Build().ConfigureApplication();

try
{
    Log.Information("Starting the application...");
    app.Run();
    return 0;
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly.");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}