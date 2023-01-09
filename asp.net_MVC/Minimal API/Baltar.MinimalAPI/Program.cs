var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var todo = new Todo(Guid.NewGuid(), "Ir a Academia", false);
    return Results.Ok(todo);
});

app.Run();
