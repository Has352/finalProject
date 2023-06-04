using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asp.net_Project.Migrations
{
    /// <inheritdoc />
    public partial class StepsDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StepsM",
                columns: table => new
                {
                    dates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    stepsNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StepsM", x => x.dates);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StepsM");
        }
    }
}
