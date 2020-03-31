using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingApp.Migrations
{
    public partial class SecondCreate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Restaurants_restaurantId",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "restaurantId",
                table: "Reservations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Restaurants_restaurantId",
                table: "Reservations",
                column: "restaurantId",
                principalTable: "Restaurants",
                principalColumn: "restaurantId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Restaurants_restaurantId",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "restaurantId",
                table: "Reservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Restaurants_restaurantId",
                table: "Reservations",
                column: "restaurantId",
                principalTable: "Restaurants",
                principalColumn: "restaurantId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
