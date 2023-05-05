using System;
using Microsoft.EntityFrameworkCore;
using TodoListApp.Data;

namespace TodoListApp.DataExtensions
{
	public static class ModelBuilderDataExtensions
	{
		public static void SeedTodos(this ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<TodoData>().HasData(new TodoData
            {
                Id = Guid.Parse("6cd25b50-ee4c-4fe0-a0eb-4df276d1f9fc"),
                Name = "Clean up Room",
                Description = "Clean up your room before your friends come over - Granny",
                DueDate = DateTime.Parse("9/12/2023"),
                IsCompleted = false

            });

            modelBuilder.Entity<TodoData>().HasData(new TodoData
            {
                Id = Guid.Parse("f5e51c5c-868e-4beb-8b12-eb79b3cc7dd3"),
                Name ="Play board games w/ Ali and Edward",
                Description = "Destroy AAli and Edward at Settler's of Catan",
                DueDate = DateTime.Parse("5/26/23")

            });

        }
    }
}

