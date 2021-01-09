using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSqLite.Migrations
{
    public partial class DefiningUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "users",
                newName: "birthdate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "birthdate",
                table: "users",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "users",
                newName: "Id");
        }
    }
}
