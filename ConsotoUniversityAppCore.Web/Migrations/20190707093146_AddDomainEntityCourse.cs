using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsotoUniversityAppCore.Web.Migrations
{
    public partial class AddDomainEntityCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Crt_User",
                table: "Course",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Crt_User",
                table: "Course");
        }
    }
}
