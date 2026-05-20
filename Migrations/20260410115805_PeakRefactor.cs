using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kanban.Migrations
{
    /// <inheritdoc />
    public partial class PeakRefactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedToUserId",
                table: "Tasks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "Tasks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedToUserId", "CreatedAt", "DueDate", "Priority" },
                values: new object[] { null, new DateTime(2026, 4, 10, 14, 58, 5, 394, DateTimeKind.Local).AddTicks(4994), new DateTime(2026, 4, 8, 14, 58, 5, 394, DateTimeKind.Local).AddTicks(5011), 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedToUserId", "CreatedAt", "DueDate", "Priority" },
                values: new object[] { null, new DateTime(2026, 4, 10, 14, 58, 5, 394, DateTimeKind.Local).AddTicks(5019), new DateTime(2026, 4, 11, 14, 58, 5, 394, DateTimeKind.Local).AddTicks(5020), 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedToUserId", "CreatedAt", "DueDate", "Priority" },
                values: new object[] { null, new DateTime(2026, 4, 10, 14, 58, 5, 394, DateTimeKind.Local).AddTicks(5021), new DateTime(2026, 4, 13, 14, 58, 5, 394, DateTimeKind.Local).AddTicks(5022), 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedToUserId", "CreatedAt", "DueDate", "Priority" },
                values: new object[] { null, new DateTime(2026, 4, 10, 14, 58, 5, 394, DateTimeKind.Local).AddTicks(5023), new DateTime(2026, 4, 15, 14, 58, 5, 394, DateTimeKind.Local).AddTicks(5024), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AssignedToUserId",
                table: "Tasks",
                column: "AssignedToUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AspNetUsers_AssignedToUserId",
                table: "Tasks",
                column: "AssignedToUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AspNetUsers_AssignedToUserId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_AssignedToUserId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "AssignedToUserId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Tasks");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 8, 15, 20, 25, 93, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 8, 15, 20, 25, 93, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 8, 15, 20, 25, 93, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 8, 15, 20, 25, 93, DateTimeKind.Local).AddTicks(6651));
        }
    }
}
