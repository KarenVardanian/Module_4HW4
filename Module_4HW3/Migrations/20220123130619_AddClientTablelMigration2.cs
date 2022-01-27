using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Module_4HW3.Migrations
{
    public partial class AddClientTablelMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Clients", "Age", "LastName", "Name", "Phone" },
                values: new object[] { 6, 18, "Petenko", "Stepan2", "380955831312" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Clients",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 1,
                column: "StartedDate",
                value: new DateTime(2022, 1, 23, 15, 4, 12, 326, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 2,
                column: "StartedDate",
                value: new DateTime(2022, 1, 23, 15, 4, 12, 329, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 3,
                column: "StartedDate",
                value: new DateTime(2022, 1, 23, 15, 4, 12, 329, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 4,
                column: "StartedDate",
                value: new DateTime(2022, 1, 23, 15, 4, 12, 329, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 5,
                column: "StartedDate",
                value: new DateTime(2022, 1, 23, 15, 4, 12, 329, DateTimeKind.Local).AddTicks(8412));
        }
    }
}
