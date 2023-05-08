using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportMonitorAPI.AppContext.Migrations
{
    public partial class UpdateUserTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "TestTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(5871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(3455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PhysichalTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(4106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "MeasurementTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(2563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 488, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 617, DateTimeKind.Local).AddTicks(7525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 488, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "GamePerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 488, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84952520-b2d9-4dbb-9a4b-da9fbe2abcc9", "252238e4-8bf6-4194-8bc4-92157d501cb6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88d95473-1a51-4c91-899b-41fafe42e87a", "f8080d14-051a-4bbb-93a6-e9c0ccfb1a05", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b92662d6-8382-47c9-854a-48577a4f4efd", "7ba6bfc1-0900-4b55-80b6-917be005dfb9", "Player", "PLAYER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84952520-b2d9-4dbb-9a4b-da9fbe2abcc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88d95473-1a51-4c91-899b-41fafe42e87a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b92662d6-8382-47c9-854a-48577a4f4efd");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "TestTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(5691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(2867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PhysichalTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(3684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "MeasurementTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 489, DateTimeKind.Local).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 488, DateTimeKind.Local).AddTicks(9262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 488, DateTimeKind.Local).AddTicks(543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 617, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "GamePerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 11, 0, 19, 488, DateTimeKind.Local).AddTicks(8394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
