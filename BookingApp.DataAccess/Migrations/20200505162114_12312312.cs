﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingApp.DataAccess.Migrations
{
    public partial class _12312312 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "AspNetUsers");
        }
    }
}
