using Microsoft.EntityFrameworkCore.Migrations;

namespace YZU.Data.Migrations
{
    public partial class addCourseCartToDatabaseWithCOunt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "CourseCart",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "CourseCart");
        }
    }
}
