using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Module_4HW3.Migrations
{
    public partial class AddClientTablelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientsId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Term",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Clients = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Clients);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Clients", "Age", "LastName", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 25, "Petrov", "Client1", "380994832312" },
                    { 2, 53, "Sidorov", "Ivan", "380664832312" },
                    { 3, 36, "Begunenko", "Petr", "38099465312" },
                    { 4, 18, "Petenko", "Stepan", "380955831312" },
                    { 5, 67, "Sidorenko", "Nikolay", "380974837862" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Project", "Budget", "ClientsId", "Name", "StartedDate", "Term" },
                values: new object[,]
                {
                    { 1, 12000.0, 1, "First", new DateTime(2022, 1, 23, 15, 4, 12, 326, DateTimeKind.Local).AddTicks(7881), 21 },
                    { 2, 14000.0, 1, "Second", new DateTime(2022, 1, 23, 15, 4, 12, 329, DateTimeKind.Local).AddTicks(8366), 30 },
                    { 3, 20000.0, 1, "Third", new DateTime(2022, 1, 23, 15, 4, 12, 329, DateTimeKind.Local).AddTicks(8403), 50 },
                    { 4, 30000.0, 1, "Fourth", new DateTime(2022, 1, 23, 15, 4, 12, 329, DateTimeKind.Local).AddTicks(8409), 14 },
                    { 5, 10000.0, 2, "fifth", new DateTime(2022, 1, 23, 15, 4, 12, 329, DateTimeKind.Local).AddTicks(8412), 79 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientsId",
                table: "Project",
                column: "ClientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Clients_ClientsId",
                table: "Project",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "Clients",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Clients_ClientsId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Project_ClientsId",
                table: "Project");

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Project",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ClientsId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Term",
                table: "Project");
        }
    }
}
