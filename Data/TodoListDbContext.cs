using System;
using Microsoft.EntityFrameworkCore;
using TodoListApp.DataExtensions;

namespace TodoListApp.Data
{
	public class TodoListDbContext: DbContext
	{
		public TodoListDbContext(DbContextOptions options): base(options) { }

		public DbSet<TodoData> Todos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedTodos();
        }
    }
}

