using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eacmm.Repositories.Migrations
{
    public partial class somerealtionshipadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "Headsets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "GuestCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "EntranceCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "Drawers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "Departments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "Cabinets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Headsets_EmployeeId",
                table: "Headsets",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestCards_EmployeeId",
                table: "GuestCards",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntranceCards_EmployeeId",
                table: "EntranceCards",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Drawers_EmployeeId",
                table: "Drawers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cabinets_EmployeeId",
                table: "Cabinets",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IX_Headsets_EmployeeId",
                table: "Headsets");

            migrationBuilder.DropIndex(
                name: "IX_GuestCards_EmployeeId",
                table: "GuestCards");

            migrationBuilder.DropIndex(
                name: "IX_EntranceCards_EmployeeId",
                table: "EntranceCards");

            migrationBuilder.DropIndex(
                name: "IX_Drawers_EmployeeId",
                table: "Drawers");

            migrationBuilder.DropIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Cabinets_EmployeeId",
                table: "Cabinets");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Headsets");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "GuestCards");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EntranceCards");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Drawers");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Cabinets");
        }
    }
}
