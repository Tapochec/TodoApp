using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Database.Migrations
{
    public partial class AddForeignIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[] { 1, "andrew@example.com", "qwe" });

            migrationBuilder.InsertData(
                table: "TaskLists",
                columns: new[] { "Id", "Name", "TaskGroupId", "UserId" },
                values: new object[] { 1, "List1", null, 1 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CompletionDt", "Desc", "Name", "TaskListId" },
                values: new object[] { 1, null, "Desc1", "Task1", 1 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CompletionDt", "Desc", "Name", "TaskListId" },
                values: new object[] { 2, null, "Desc2", "Task2", 1 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CompletionDt", "Desc", "Name", "TaskListId" },
                values: new object[] { 3, null, "Desc3", "Task3", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaskLists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
