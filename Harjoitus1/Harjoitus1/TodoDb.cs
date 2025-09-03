using Microsoft.EntityFrameworkCore;

namespace Harjoitus1
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options) : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
