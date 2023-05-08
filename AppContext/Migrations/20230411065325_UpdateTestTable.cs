using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportMonitorAPI.AppContext.Migrations
{
    public partial class UpdateTestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(4310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(2012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PhysichalTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(2646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.AddColumn<bool>(
                name: "CompareRuleAscending",
                table: "PhysichalTests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "MeasurementTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(1148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 549, DateTimeKind.Local).AddTicks(9331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 549, DateTimeKind.Local).AddTicks(6199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 617, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "GamePerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 549, DateTimeKind.Local).AddTicks(8717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(149));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CompareRuleAscending",
                table: "PhysichalTests");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "TestTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(5871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(3455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PhysichalTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(4106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "MeasurementTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(2563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 550, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 549, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 617, DateTimeKind.Local).AddTicks(7525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 549, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "GamePerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 29, 11, 56, 56, 618, DateTimeKind.Local).AddTicks(149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 11, 9, 53, 25, 549, DateTimeKind.Local).AddTicks(8717));

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
    }
}
