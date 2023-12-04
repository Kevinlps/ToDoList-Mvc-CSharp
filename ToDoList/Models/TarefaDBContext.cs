using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class TarefaDBContext : DbContext
    {
        public TarefaDBContext(DbContextOptions<TarefaDBContext> options) : base(options) { }

        public DbSet<Tarefa> Tarefa { get; set; }
    }
}
