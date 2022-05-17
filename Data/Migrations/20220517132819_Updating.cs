using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Updating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaxClassSize",
                table: "Classes",
                newName: "MaxCourseSize");

            migrationBuilder.RenameColumn(
                name: "ClassName",
                table: "Classes",
                newName: "CourseName");

            migrationBuilder.RenameColumn(
                name: "ClassID",
                table: "Classes",
                newName: "CourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaxCourseSize",
                table: "Classes",
                newName: "MaxClassSize");

            migrationBuilder.RenameColumn(
                name: "CourseName",
                table: "Classes",
                newName: "ClassName");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Classes",
                newName: "ClassID");
        }
    }
}
