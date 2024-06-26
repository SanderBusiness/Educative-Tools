using API.Helpers.Program;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPlugins();

var app = builder.Build();

app.EnablePlugins();

app.Run();