using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingApp.DataAccess.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Barbershops",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ImgPath = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AdministratorId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barbershops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barbershops_Administrators_AdministratorId",
                        column: x => x.AdministratorId,
                        principalTable: "Administrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ImgPath = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AdministratorId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cinemas_Administrators_AdministratorId",
                        column: x => x.AdministratorId,
                        principalTable: "Administrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ImgPath = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AdministratorId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurants_Administrators_AdministratorId",
                        column: x => x.AdministratorId,
                        principalTable: "Administrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BarbershopReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BarbershopId = table.Column<Guid>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    StartHour = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarbershopReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BarbershopReservations_Barbershops_BarbershopId",
                        column: x => x.BarbershopId,
                        principalTable: "Barbershops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BarbershopReservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CinemaReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CinemaId = table.Column<Guid>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    StartHour = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CinemaReservations_Cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CinemaReservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RestaurantId = table.Column<Guid>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    StartHour = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantReservations_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RestaurantReservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BarbershopReservations_BarbershopId",
                table: "BarbershopReservations",
                column: "BarbershopId");

            migrationBuilder.CreateIndex(
                name: "IX_BarbershopReservations_UserId",
                table: "BarbershopReservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Barbershops_AdministratorId",
                table: "Barbershops",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_CinemaReservations_CinemaId",
                table: "CinemaReservations",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_CinemaReservations_UserId",
                table: "CinemaReservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_AdministratorId",
                table: "Cinemas",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantReservations_RestaurantId",
                table: "RestaurantReservations",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantReservations_UserId",
                table: "RestaurantReservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_AdministratorId",
                table: "Restaurants",
                column: "AdministratorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarbershopReservations");

            migrationBuilder.DropTable(
                name: "CinemaReservations");

            migrationBuilder.DropTable(
                name: "ContactMessages");

            migrationBuilder.DropTable(
                name: "RestaurantReservations");

            migrationBuilder.DropTable(
                name: "Barbershops");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Administrators");
        }
    }
}
