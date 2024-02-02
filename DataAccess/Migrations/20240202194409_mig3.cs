using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOut",
                table: "T_Cards",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 23, 44, 9, 167, DateTimeKind.Local).AddTicks(1432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2024, 2, 2, 22, 23, 36, 56, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOut",
                table: "S_Cards",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 23, 44, 9, 167, DateTimeKind.Local).AddTicks(374),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2024, 2, 2, 22, 23, 36, 56, DateTimeKind.Local).AddTicks(8196));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOut",
                table: "T_Cards",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 22, 23, 36, 56, DateTimeKind.Local).AddTicks(9381),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2024, 2, 2, 23, 44, 9, 167, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOut",
                table: "S_Cards",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 2, 22, 23, 36, 56, DateTimeKind.Local).AddTicks(8196),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2024, 2, 2, 23, 44, 9, 167, DateTimeKind.Local).AddTicks(374));
        }
    }
}
