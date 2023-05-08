using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportMonitorAPI.AppContext.Migrations
{
    public partial class UpdateUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57cf894c-1705-4335-9a45-23d3806d2fed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86a4e1bb-e92e-4952-8227-fd18fabeb4c2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "TestTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(5505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 691, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(2381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 691, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PhysichalTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(3173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 691, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "MeasurementTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(1396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 690, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 995, DateTimeKind.Local).AddTicks(9163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 690, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 995, DateTimeKind.Local).AddTicks(5061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 690, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "GamePerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 995, DateTimeKind.Local).AddTicks(8391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 690, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenCreated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenExpires",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "191d787d-815c-4a14-b86e-6ee7aed3f060", "31f1892c-901d-4794-bf15-81c94e7b3360", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39fd440b-0e5f-4d56-8eb3-74e58e07231a", "3fc6a318-1aa6-4f4f-a3bf-180bc06bc91a", "Player", "PLAYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7cb55d75-9a71-4b7e-a1b2-ee63ad7d596d", "3913a8bd-ab53-406e-a47d-c25f0420dedf", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "191d787d-815c-4a14-b86e-6ee7aed3f060");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39fd440b-0e5f-4d56-8eb3-74e58e07231a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cb55d75-9a71-4b7e-a1b2-ee63ad7d596d");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TokenCreated",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TokenExpires",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "TestTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 691, DateTimeKind.Local).AddTicks(2946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 691, DateTimeKind.Local).AddTicks(566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PhysichalTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 691, DateTimeKind.Local).AddTicks(1248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "MeasurementTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 690, DateTimeKind.Local).AddTicks(9675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 690, DateTimeKind.Local).AddTicks(7948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 995, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 690, DateTimeKind.Local).AddTicks(4782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 995, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "GamePerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 14, 15, 48, 37, 690, DateTimeKind.Local).AddTicks(7403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 995, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57cf894c-1705-4335-9a45-23d3806d2fed", "fdf3c08b-b8f2-4014-9311-59659c1faeb9", "Player", "PLAYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "86a4e1bb-e92e-4952-8227-fd18fabeb4c2", "939355c2-7a4f-4e2a-946b-0295b6c7e088", "Admin", "ADMIN" });
        }
    }
}
