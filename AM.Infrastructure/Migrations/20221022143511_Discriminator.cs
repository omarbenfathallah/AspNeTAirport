using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class Discriminator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Passengers");

            migrationBuilder.AddColumn<int>(
                name: "PassengerTypeValue",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassengerTypeValue",
                table: "Passengers");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
