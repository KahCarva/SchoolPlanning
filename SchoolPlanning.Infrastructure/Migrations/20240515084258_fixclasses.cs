using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPlanning.Infrastructure.Migrations
{
    public partial class fixclasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_ClassesId",
                schema: "Entity",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ClassesId",
                schema: "Entity",
                table: "Employee",
                column: "ClassesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_ClassesId",
                schema: "Entity",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ClassesId",
                schema: "Entity",
                table: "Employee",
                column: "ClassesId",
                unique: true);
        }
    }
}
