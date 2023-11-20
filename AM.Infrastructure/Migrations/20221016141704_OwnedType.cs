using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class OwnedType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Passengers",
                newName: "FullNameLast");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Passengers",
                newName: "FullNameFirst");

            migrationBuilder.AlterColumn<string>(
                name: "FullNameLast",
                table: "Passengers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "FullNameFirst",
                table: "Passengers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullNameLast",
                table: "Passengers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FullNameFirst",
                table: "Passengers",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Passengers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passengers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: false);
        }
    }
}
