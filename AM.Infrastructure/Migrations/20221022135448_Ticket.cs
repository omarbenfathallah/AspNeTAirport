using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class Ticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightPassenger");

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Seat = table.Column<int>(type: "int", nullable: false),
                    FlightKey = table.Column<int>(type: "int", nullable: false),
                    PassengerKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => new { x.Seat, x.FlightKey, x.PassengerKey });
                    table.ForeignKey(
                        name: "FK_Tickets_Flights_FlightKey",
                        column: x => x.FlightKey,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Passengers_PassengerKey",
                        column: x => x.PassengerKey,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FlightKey",
                table: "Tickets",
                column: "FlightKey");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PassengerKey",
                table: "Tickets",
                column: "PassengerKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.CreateTable(
                name: "FlightPassenger",
                columns: table => new
                {
                    FlightsFlightId = table.Column<int>(type: "int", nullable: false),
                    PassengersPassportNumber = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPassenger", x => new { x.FlightsFlightId, x.PassengersPassportNumber });
                    table.ForeignKey(
                        name: "FK_FlightPassenger_Flights_FlightsFlightId",
                        column: x => x.FlightsFlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightPassenger_Passengers_PassengersPassportNumber",
                        column: x => x.PassengersPassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_PassengersPassportNumber",
                table: "FlightPassenger",
                column: "PassengersPassportNumber");
        }
    }
}
