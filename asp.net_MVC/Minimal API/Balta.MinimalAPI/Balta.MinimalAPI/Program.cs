using Balta.MinimalAPI.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(); 

var app = builder.Build();

app.MapGet("v1/todos", (AppDbContext context) =>
{
    var todos = context.Todos.ToList();
    //var todo = new Todo(Guid.NewGuid(), "Ir a academia", false);
    //resultados Https
    return Results.Ok(todo);

});

app.Run();
