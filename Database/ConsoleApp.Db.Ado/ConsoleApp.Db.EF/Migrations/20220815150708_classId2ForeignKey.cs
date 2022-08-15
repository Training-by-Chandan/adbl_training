using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp.Db.EF.Migrations
{
    public partial class classId2ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClassId2",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId2",
                table: "Students",
                column: "ClassId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId2",
                table: "Students",
                column: "ClassId2",
                principalTable: "Classes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId2",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassId2",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId2",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
