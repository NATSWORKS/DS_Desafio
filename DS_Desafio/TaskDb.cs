using Microsoft.EntityFrameworkCore;

namespace DS_Desafio
{
    public class TaskDb : DbContext
    {
        public TaskDb(DbContextOptions<TaskDb> options) : base(options) { }

        public DbSet<Task> Tasks => Set<Task>();
    }
}
