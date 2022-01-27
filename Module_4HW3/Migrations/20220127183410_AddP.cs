using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Module_4HW3.Migrations
{
    public partial class AddP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 1, 27, 20, 34, 10, 329, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 1, 27, 20, 34, 10, 333, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2022, 1, 27, 20, 34, 10, 333, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 4,
                column: "StartedDate",
                value: new DateTime(2022, 1, 27, 20, 34, 10, 333, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 5,
                column: "StartedDate",
                value: new DateTime(2022, 1, 27, 20, 34, 10, 333, DateTimeKind.Local).AddTicks(373));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 1, 23, 15, 6, 18, 905, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 1, 23, 15, 6, 18, 908, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2022, 1, 23, 15, 6, 18, 908, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 4,
                column: "StartedDate",
                value: new DateTime(2022, 1, 23, 15, 6, 18, 908, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 5,
                column: "StartedDate",
                value: new DateTime(2022, 1, 23, 15, 6, 18, 908, DateTimeKind.Local).AddTicks(955));
        }
    }
}
