var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/{id}", (int id) => id < 0 ? Results.BadRequest() : Results.Accepted());

app.Run();