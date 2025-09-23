using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagment.Migrations
{
    /// <inheritdoc />
    public partial class RenameGradeToFinalGrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Enrollments");

            migrationBuilder.AddColumn<int>(
                name: "FinalGrade",
                table: "Enrollments",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalGrade",
                table: "Enrollments");

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
