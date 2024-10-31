using DS_Desafio;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TaskDb>(opt => opt.UseInMemoryDatabase("TaskList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();

app.MapGet("/taskitems", async (TaskDb db) =>
    await db.Tasks.ToListAsync());

/*app.MapGet("/taskitems/complete", async (TaskDb db) =>
    await db.Tasks.Where(t => t.IsComplete).ToListAsync());*/

app.MapGet("/taskitems/{id}", async (int id, TaskDb db) =>
    await db.Tasks.FindAsync(id)
        is DS_Desafio.Task task
            ? Results.Ok(task)
            : Results.NotFound());

app.MapPost("/taskitems", async (DS_Desafio.Task task, TaskDb db) =>
{
    db.Tasks.Add(task);
    await db.SaveChangesAsync();

    return Results.Created($"/taskitems/{task.id}", task);
});

app.MapPut("/taskitems/{id}", async (int id, DS_Desafio.Task inputTask, TaskDb db) =>
{
    var task = await db.Tasks.FindAsync(id);

    if (task is null) return Results.NotFound();

    task.title = inputTask.title;
    //task.IsComplete = inputTask.IsComplete;//--------------------

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/taskitems/{id}", async (int id, TaskDb db) =>
{
    if (await db.Tasks.FindAsync(id) is DS_Desafio.Task task)
    {
        db.Tasks.Remove(task);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }

    return Results.NotFound();
});

app.Run();
