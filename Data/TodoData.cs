using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.Data
{
	[Table("Todo")]
	public class TodoData
	{
		[Key]
		public Guid Id { get; set; }
		[MaxLength(50)]
		public string Name { get; set; }
		[MaxLength(500)]
		public string Description { get; set; }
		public DateTime? DueDate { get; set; }
		public bool IsCompleted { get; set; }	
	}
}

