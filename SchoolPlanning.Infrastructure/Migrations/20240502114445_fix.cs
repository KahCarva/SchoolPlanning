using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPlanning.Infrastructure.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_SchoolId",
                schema: "Entity",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_SchoolId",
                schema: "Entity",
                table: "Employee",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_SchoolId",
                schema: "Entity",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_SchoolId",
                schema: "Entity",
                table: "Employee",
                column: "SchoolId",
                unique: true);
        }
    }
}
