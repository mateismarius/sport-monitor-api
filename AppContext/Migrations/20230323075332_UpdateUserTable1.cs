using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportMonitorAPI.AppContext.Migrations
{
    public partial class UpdateUserTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "TestTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(8039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(5133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PhysichalTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(6034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "MeasurementTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(4153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(2112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 995, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 766, DateTimeKind.Local).AddTicks(7871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 995, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "GamePerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(1364),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 995, DateTimeKind.Local).AddTicks(8391));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "TestTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(5505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(2381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "PhysichalTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(3173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "MeasurementTakens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 996, DateTimeKind.Local).AddTicks(1396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 995, DateTimeKind.Local).AddTicks(9163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 995, DateTimeKind.Local).AddTicks(5061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 766, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "GamePerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 23, 9, 49, 54, 995, DateTimeKind.Local).AddTicks(8391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 23, 9, 53, 31, 767, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

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
    }
}
