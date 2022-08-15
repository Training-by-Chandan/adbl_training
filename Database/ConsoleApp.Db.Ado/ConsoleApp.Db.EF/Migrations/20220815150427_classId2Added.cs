using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp.Db.EF.Migrations
{
    public partial class classId2Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassId2",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassId2",
                table: "Students");
        }
    }
}
