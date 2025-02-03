using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestMVC.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeePhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateofJoining = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__7AD04FF1D599AAAB", x => x.EmployeeID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
