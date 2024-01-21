using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TodoApi.Models;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }
        public DbSet<TodoApi.Models.TodoItemDTO> TodoItem { get; set; } = default!;
    }
}
