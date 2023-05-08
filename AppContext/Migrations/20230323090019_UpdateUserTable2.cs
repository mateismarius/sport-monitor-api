using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportMonitorAPI.AppContext.Migrations
{
    public partial class UpdateUserTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "671c673e-44b6-4fd1-8ac3-04b503e41624");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a13f71e9-4181-49ff-912f-62d7f4b648fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2502082-f8cf-4c7a-ad2b-5a729456d48d");

            migrationBuilder.DropColumn(
                name: "TokenCreated",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "TokenExpires",
                table: "AspNetUsers",
                newName: "RefreshTokenExpiryTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "TestTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(5691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(2867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PhysichalTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(3684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "MeasurementTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 488, DateTimeKind.Local).AddTicks(9262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 488, DateTimeKind.Local).AddTicks(543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 766, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "GamePerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 488, DateTimeKind.Local).AddTicks(8394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f00b2ae-1d11-4e47-8d3d-aab153fde5a1", "b7f5361e-8802-4ef6-8eb6-14469c9995cf", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10094b36-0171-4a28-b011-d198e7cb8ab9", "cc5ba82b-9c6a-432e-958e-071128b4446a", "Player", "PLAYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98d3b2e0-07f3-465c-8615-ac092a1f5f30", "a6488d62-19e5-43bc-973e-ac6ee7b71d52", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f00b2ae-1d11-4e47-8d3d-aab153fde5a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10094b36-0171-4a28-b011-d198e7cb8ab9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98d3b2e0-07f3-465c-8615-ac092a1f5f30");

            migrationBuilder.RenameColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                newName: "TokenExpires");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "TestTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(8039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(5133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PhysichalTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(6034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "MeasurementTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(4153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(2112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 488, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 766, DateTimeKind.Local).AddTicks(7871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 488, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "GamePerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(1364),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 488, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "671c673e-44b6-4fd1-8ac3-04b503e41624", "f673575f-3dd3-43f7-a3ce-edae3dbec4ac", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a13f71e9-4181-49ff-912f-62d7f4b648fd", "0a5b1515-f411-4ae6-a0ed-418fd1c7d4cc", "Player", "PLAYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2502082-f8cf-4c7a-ad2b-5a729456d48d", "0d6228d3-9c0b-42cf-a3dd-b252ff1de6e2", "Admin", "ADMIN" });
        }
    }
}
