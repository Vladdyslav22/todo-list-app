using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_Application.Migrations
{
    /// <inheritdoc />
    public partial class AddPriorityField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deadline",
                table: "Tasks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Deadline",
                table: "Tasks",
                type: "datetime2",
                nullable: true);
        }
    }
}
