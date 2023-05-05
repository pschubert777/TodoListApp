using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoListApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "Description", "DueDate", "IsCompleted", "Name" },
                values: new object[,]
                {
                    { new Guid("6cd25b50-ee4c-4fe0-a0eb-4df276d1f9fc"), "Clean up your room before your friends come over - Granny", new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Clean up Room" },
                    { new Guid("f5e51c5c-868e-4beb-8b12-eb79b3cc7dd3"), "Destroy AAli and Edward at Settler's of Catan", new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Play board games w/ Ali and Edward" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todo");
        }
    }
}
