using DS_Desafio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TaskDb>(opt => opt.UseInMemoryDatabase("TaskList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDbContext<TaskDb>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

/*app.MapGet("/taskitems", async (TaskDb db) =>
    await db.Tasks.ToListAsync());

app.MapGet("/taskitems/{id}", async (int id, TaskDb db) =>
    await db.Tasks.FindAsync(id)
        is DS_Desafio.Task task
            ? Results.Ok(task)
            : Results.NotFound());

app.MapPost("/taskitems", async (DS_Desafio.Task task, TaskDb db) =>
{
    db.Tasks.Add(task);
    await db.SaveChangesAsync();

    return Results.Created($"/taskitems/{task.Id}", task);
});

app.MapPut("/taskitems/{id}", async (int id, DS_Desafio.Task inputTask, TaskDb db) =>
{
    var task = await db.Tasks.FindAsync(id);

    if (task is null) return Results.NotFound();

    task.Title = inputTask.Title;
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
});*/

app.Run();
