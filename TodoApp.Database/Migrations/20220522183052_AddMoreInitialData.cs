using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Database.Migrations
{
    public partial class AddMoreInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ListGroups",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { 1, "Group 1", 1 });

            migrationBuilder.InsertData(
                table: "TaskLists",
                columns: new[] { "Id", "Name", "TaskGroupId", "UserId" },
                values: new object[] { 2, "List2", 1, 1 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CompletionDt", "Desc", "Name", "TaskListId" },
                values: new object[] { 4, null, "Desc4", "Task4", 2 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CompletionDt", "Desc", "Name", "TaskListId" },
                values: new object[] { 5, null, "Desc5", "Task5", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TaskLists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ListGroups",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
