using API.Helpers.Program;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPlugins();

var app = builder.Build();
app.EnablePlugins();

app.Run();
