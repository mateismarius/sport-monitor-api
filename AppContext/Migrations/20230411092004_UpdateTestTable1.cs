using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportMonitorAPI.AppContext.Migrations
{
    public partial class UpdateTestTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3adc30f7-f857-415f-9e79-4046520f317b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81ef51ef-2525-446f-8341-673be42edb8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee9654c4-3920-4269-a5e4-b234fd9d634b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "TestTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 292, DateTimeKind.Local).AddTicks(2219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 291, DateTimeKind.Local).AddTicks(8998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Players",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PhysichalTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 291, DateTimeKind.Local).AddTicks(9601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "MeasurementTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 291, DateTimeKind.Local).AddTicks(8068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 291, DateTimeKind.Local).AddTicks(6109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 549, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 291, DateTimeKind.Local).AddTicks(1433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 549, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "GamePerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 291, DateTimeKind.Local).AddTicks(5477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 549, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0426eda0-d7f1-4d0b-9cab-d6a9e2447471", "9ff900f9-8f36-489d-95fe-5dd26e4a9ca5", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "678a842e-db5a-4939-8374-73aaff594b38", "d1f98a26-8856-46c1-b8d0-6056c4c273a0", "Player", "PLAYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca295801-a6e8-4a2d-9d7a-12eb5d2a8a41", "d0bda2af-d187-4bdb-932d-9928ca84de3a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0426eda0-d7f1-4d0b-9cab-d6a9e2447471");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "678a842e-db5a-4939-8374-73aaff594b38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca295801-a6e8-4a2d-9d7a-12eb5d2a8a41");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "TestTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(4310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 292, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(2012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 291, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Players",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PhysichalTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(2646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 291, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "MeasurementTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(1148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 291, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 549, DateTimeKind.Local).AddTicks(9331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 291, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 549, DateTimeKind.Local).AddTicks(6199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 291, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "GamePerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 549, DateTimeKind.Local).AddTicks(8717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 12, 20, 4, 291, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3adc30f7-f857-415f-9e79-4046520f317b", "0bd2c9de-9211-42b0-bfae-59b925a8b068", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81ef51ef-2525-446f-8341-673be42edb8c", "d5d3a784-2dfb-41f7-8b5e-6cc8cf7f68c8", "Player", "PLAYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee9654c4-3920-4269-a5e4-b234fd9d634b", "cedef4bd-cd63-4185-82e5-c5e4038577a1", "Member", "MEMBER" });
        }
    }
}
