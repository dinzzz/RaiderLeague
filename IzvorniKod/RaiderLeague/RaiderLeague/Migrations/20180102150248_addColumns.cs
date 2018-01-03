using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RaiderLeague.Migrations
{
    public partial class addColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "RegisteredUser",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "RegisteredUser",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "RegisteredUser",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "RegisteredUser");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "RegisteredUser");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "RegisteredUser");
        }
    }
}
