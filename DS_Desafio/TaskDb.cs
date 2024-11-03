using DS_Desafio;
using Microsoft.EntityFrameworkCore;

public class TaskDb : DbContext
{
    public TaskDb(DbContextOptions<TaskDb> options) : base(options) { }

    //public DbSet<Task> Tasks => Set<TaskModel>();
    public DbSet<TaskModel> Tasks { get; set; }
}
