using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolPlanning.Infrastructure.Migrations
{
    public partial class AddClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassesId",
                schema: "Entity",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Classes",
                schema: "Entity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolGrade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ClassesId",
                schema: "Entity",
                table: "Employee",
                column: "ClassesId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Classes_ClassesId",
                schema: "Entity",
                table: "Employee",
                column: "ClassesId",
                principalSchema: "Entity",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Classes_ClassesId",
                schema: "Entity",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Classes",
                schema: "Entity");

            migrationBuilder.DropIndex(
                name: "IX_Employee_ClassesId",
                schema: "Entity",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ClassesId",
                schema: "Entity",
                table: "Employee");
        }
    }
}
