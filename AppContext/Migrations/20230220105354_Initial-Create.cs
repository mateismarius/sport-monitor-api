using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportMonitorAPI.AppContext.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opponent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityGame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SportHall = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeamGoals = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    OpponentGoals = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 2, 20, 12, 53, 54, 431, DateTimeKind.Local).AddTicks(5479))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 2, 20, 12, 53, 54, 431, DateTimeKind.Local).AddTicks(8087))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhysichalTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 2, 20, 12, 53, 54, 432, DateTimeKind.Local).AddTicks(1731))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysichalTests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Feminin"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BadgeNo = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Nu este legitimat"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 2, 20, 12, 53, 54, 432, DateTimeKind.Local).AddTicks(1056))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GamePerformances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    TotalScores = table.Column<int>(type: "int", nullable: false),
                    TotalSuspension = table.Column<int>(type: "int", nullable: false),
                    Overrall = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 2, 20, 12, 53, 54, 431, DateTimeKind.Local).AddTicks(7462))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePerformances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamePerformances_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePerformances_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MeasurementTakens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasurementId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false),
                    TakenAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 2, 20, 12, 53, 54, 432, DateTimeKind.Local).AddTicks(26))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementTakens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeasurementTakens_Measurements_MeasurementId",
                        column: x => x.MeasurementId,
                        principalTable: "Measurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeasurementTakens_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TestTakens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false),
                    TakenAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 2, 20, 12, 53, 54, 432, DateTimeKind.Local).AddTicks(3650))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTakens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestTakens_PhysichalTests_TestId",
                        column: x => x.TestId,
                        principalTable: "PhysichalTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestTakens_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GamePerformances_GameId",
                table: "GamePerformances",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePerformances_PlayerId",
                table: "GamePerformances",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasurementTakens_MeasurementId",
                table: "MeasurementTakens",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasurementTakens_PlayerId",
                table: "MeasurementTakens",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TestTakens_PlayerId",
                table: "TestTakens",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TestTakens_TestId",
                table: "TestTakens",
                column: "TestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GamePerformances");

            migrationBuilder.DropTable(
                name: "MeasurementTakens");

            migrationBuilder.DropTable(
                name: "TestTakens");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropTable(
                name: "PhysichalTests");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
