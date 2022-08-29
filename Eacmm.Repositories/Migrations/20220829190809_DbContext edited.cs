using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eacmm.Repositories.Migrations
{
    public partial class DbContextedited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cabinets_Employees_EmployeeId",
                table: "Cabinets");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_EmployeeId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Drawers_Employees_EmployeeId",
                table: "Drawers");

            migrationBuilder.DropForeignKey(
                name: "FK_EntranceCards_Employees_EmployeeId",
                table: "EntranceCards");

            migrationBuilder.DropForeignKey(
                name: "FK_GuestCards_Employees_EmployeeId",
                table: "GuestCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Headsets_Employees_EmployeeId",
                table: "Headsets");

            migrationBuilder.DropIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedEmployee",
                table: "SentryToDos");

            migrationBuilder.DropColumn(
                name: "CreatedEmployee",
                table: "SentryDones");

            migrationBuilder.DropColumn(
                name: "CreatedEmployee",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Departments");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "SentryToDos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "SentryDones",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "Inventories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SentryToDos_DepartmentId",
                table: "SentryToDos",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SentryDones_DepartmentId",
                table: "SentryDones",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_DepartmentId",
                table: "Inventories",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cabinets_Employees_EmployeeId",
                table: "Cabinets",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Drawers_Employees_EmployeeId",
                table: "Drawers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EntranceCards_Employees_EmployeeId",
                table: "EntranceCards",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GuestCards_Employees_EmployeeId",
                table: "GuestCards",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Headsets_Employees_EmployeeId",
                table: "Headsets",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Departments_DepartmentId",
                table: "Inventories",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SentryDones_Departments_DepartmentId",
                table: "SentryDones",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SentryToDos_Departments_DepartmentId",
                table: "SentryToDos",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cabinets_Employees_EmployeeId",
                table: "Cabinets");

            migrationBuilder.DropForeignKey(
                name: "FK_Drawers_Employees_EmployeeId",
                table: "Drawers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EntranceCards_Employees_EmployeeId",
                table: "EntranceCards");

            migrationBuilder.DropForeignKey(
                name: "FK_GuestCards_Employees_EmployeeId",
                table: "GuestCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Headsets_Employees_EmployeeId",
                table: "Headsets");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Departments_DepartmentId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_SentryDones_Departments_DepartmentId",
                table: "SentryDones");

            migrationBuilder.DropForeignKey(
                name: "FK_SentryToDos_Departments_DepartmentId",
                table: "SentryToDos");

            migrationBuilder.DropIndex(
                name: "IX_SentryToDos_DepartmentId",
                table: "SentryToDos");

            migrationBuilder.DropIndex(
                name: "IX_SentryDones_DepartmentId",
                table: "SentryDones");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_DepartmentId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "SentryToDos");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "SentryDones");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "CreatedEmployee",
                table: "SentryToDos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedEmployee",
                table: "SentryDones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedEmployee",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "Departments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cabinets_Employees_EmployeeId",
                table: "Cabinets",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_EmployeeId",
                table: "Departments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Drawers_Employees_EmployeeId",
                table: "Drawers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntranceCards_Employees_EmployeeId",
                table: "EntranceCards",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GuestCards_Employees_EmployeeId",
                table: "GuestCards",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Headsets_Employees_EmployeeId",
                table: "Headsets",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
