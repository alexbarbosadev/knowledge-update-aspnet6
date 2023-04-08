// DOTNET 6 MINIMAL APIs

// Initializes a new instance of the WebApplicationBuilder
var builder = WebApplication.CreateBuilder(args);

// Builds the WebApplication
var app = builder.Build();

// CREATE
app.MapPost("/create", (User user) => Results.Ok());

// READ
app.MapGet("/read/{id:guid}", (Guid id) => Results.Ok());

// UPDATE
app.MapPut("/update/{id:guid}", (User user) => Results.Ok());

// DELETE
app.MapDelete("/delete/{id:guid}", () => Results.Ok());

app.Run();

public class User
{
	public Guid Id { get; set; }
	public string? Name { get; set; }
}