using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsotoUniversityAppCore.Web.Migrations
{
    public partial class ColumnDateTracking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Crt_User",
                table: "Course",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ChgeDate",
                table: "Course",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ChgeUser",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Crt_Date",
                table: "Course",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChgeDate",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "ChgeUser",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Crt_Date",
                table: "Course");

            migrationBuilder.AlterColumn<string>(
                name: "Crt_User",
                table: "Course",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
