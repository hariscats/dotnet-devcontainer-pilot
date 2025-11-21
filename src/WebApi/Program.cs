var builder = WebApplication.CreateBuilder(args);

// Add services to the container if needed in future
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => "Hello from the devcontainer .NET 8 Web API!");

app.MapGet("/health", () => Results.Ok(new { status = "ok" }));

app.Run();
