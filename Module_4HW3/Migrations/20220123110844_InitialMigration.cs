using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Module_4HW3.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Employee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HiredDate = table.Column<DateTime>(type: "datetime2", maxLength: 7, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OfficeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Employee);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Project = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Budget = table.Column<double>(type: "float", nullable: false),
                    StartedDate = table.Column<DateTime>(type: "datetime2", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Project);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    Title = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Names = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    Office = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.Office);
                    table.ForeignKey(
                        name: "FK_Office_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Employee",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTitle",
                columns: table => new
                {
                    ProjectsEmployeeId = table.Column<int>(type: "int", nullable: false),
                    TitlesTitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTitle", x => new { x.ProjectsEmployeeId, x.TitlesTitleId });
                    table.ForeignKey(
                        name: "FK_EmployeeTitle_Employee_ProjectsEmployeeId",
                        column: x => x.ProjectsEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Employee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTitle_Title_TitlesTitleId",
                        column: x => x.TitlesTitleId,
                        principalTable: "Title",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProject",
                columns: table => new
                {
                    EmployeeProject = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEmployee = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    IdProject = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    TitleId = table.Column<int>(type: "int", nullable: true),
                    idTitle = table.Column<int>(type: "int", nullable: false),
                    OfficesOfficeId = table.Column<int>(type: "int", nullable: true),
                    IdOffice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProject", x => x.EmployeeProject);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Employee",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Office_OfficesOfficeId",
                        column: x => x.OfficesOfficeId,
                        principalTable: "Office",
                        principalColumn: "Office",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Project",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "Title",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "Office", "EmployeeId", "Location", "Title" },
                values: new object[] { 1, null, "Kiev", "First" });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "Office", "EmployeeId", "Location", "Title" },
                values: new object[] { 2, null, "Kherson", "Fisecond" });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "Office", "EmployeeId", "Location", "Title" },
                values: new object[] { 3, null, "Poltava", "Third" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_EmployeeId",
                table: "EmployeeProject",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_OfficesOfficeId",
                table: "EmployeeProject",
                column: "OfficesOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_ProjectId",
                table: "EmployeeProject",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_TitleId",
                table: "EmployeeProject",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTitle_TitlesTitleId",
                table: "EmployeeTitle",
                column: "TitlesTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Office_EmployeeId",
                table: "Office",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProject");

            migrationBuilder.DropTable(
                name: "EmployeeTitle");

            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
