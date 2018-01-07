using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RaiderLeague.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErrorViewModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RequestId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorViewModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Operation",
                columns: table => new
                {
                    operationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OperationName = table.Column<string>(nullable: true),
                    difficulty = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operation", x => x.operationID);
                });

            migrationBuilder.CreateTable(
                name: "RegisteredUser",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessLevel = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Klasa = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredUser", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Boss",
                columns: table => new
                {
                    BossID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BossName = table.Column<string>(nullable: true),
                    Damage = table.Column<int>(nullable: false),
                    Difficulty = table.Column<int>(nullable: true),
                    Health = table.Column<int>(nullable: false),
                    operationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boss", x => x.BossID);
                    table.ForeignKey(
                        name: "FK_Boss_Operation_operationID",
                        column: x => x.operationID,
                        principalTable: "Operation",
                        principalColumn: "operationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BattleLog",
                columns: table => new
                {
                    battleLogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BossID = table.Column<int>(nullable: true),
                    klasa = table.Column<int>(nullable: true),
                    log = table.Column<string>(nullable: true),
                    operationID = table.Column<int>(nullable: true),
                    role = table.Column<int>(nullable: true),
                    userID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleLog", x => x.battleLogID);
                    table.ForeignKey(
                        name: "FK_BattleLog_Boss_BossID",
                        column: x => x.BossID,
                        principalTable: "Boss",
                        principalColumn: "BossID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BattleLog_Operation_operationID",
                        column: x => x.operationID,
                        principalTable: "Operation",
                        principalColumn: "operationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BattleLog_RegisteredUser_userID",
                        column: x => x.userID,
                        principalTable: "RegisteredUser",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BattleLog_BossID",
                table: "BattleLog",
                column: "BossID");

            migrationBuilder.CreateIndex(
                name: "IX_BattleLog_operationID",
                table: "BattleLog",
                column: "operationID");

            migrationBuilder.CreateIndex(
                name: "IX_BattleLog_userID",
                table: "BattleLog",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_Boss_operationID",
                table: "Boss",
                column: "operationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BattleLog");

            migrationBuilder.DropTable(
                name: "ErrorViewModel");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "Boss");

            migrationBuilder.DropTable(
                name: "RegisteredUser");

            migrationBuilder.DropTable(
                name: "Operation");
        }
    }
}
