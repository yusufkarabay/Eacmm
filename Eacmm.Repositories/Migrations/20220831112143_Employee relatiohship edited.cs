using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eacmm.Repositories.Migrations
{
    public partial class Employeerelatiohshipedited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cabinets_Employees_EmployeeId",
                table: "Cabinets");

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
                name: "IX_Cabinets_EmployeeId",
                table: "Cabinets");

            migrationBuilder.DropColumn(
                name: "DeliveryEmployee",
                table: "Headsets");

            migrationBuilder.DropColumn(
                name: "ReceiverEmployee",
                table: "Headsets");

            migrationBuilder.DropColumn(
                name: "DeliveryEmployee",
                table: "GuestCards");

            migrationBuilder.DropColumn(
                name: "ReceiverEmployee",
                table: "GuestCards");

            migrationBuilder.DropColumn(
                name: "DeliveryEmployee",
                table: "EntranceCards");

            migrationBuilder.DropColumn(
                name: "ReceiverEmployee",
                table: "EntranceCards");

            migrationBuilder.DropColumn(
                name: "DeliveryEmployee",
                table: "Drawers");

            migrationBuilder.DropColumn(
                name: "ReceiverEmployee",
                table: "Drawers");

            migrationBuilder.DropColumn(
                name: "DeliveryEmployee",
                table: "Cabinets");

            migrationBuilder.DropColumn(
                name: "ReceiverEmployee",
                table: "Cabinets");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Headsets",
                newName: "ReceiverEmployeeId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "GuestCards",
                newName: "ReceiverEmployeeId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "EntranceCards",
                newName: "ReceiverEmployeeId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Drawers",
                newName: "ReceiverEmployeeId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Cabinets",
                newName: "ReceiverEmployeeId");

            migrationBuilder.AddColumn<Guid>(
                name: "DeliveryEmployeeId",
                table: "Headsets",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeliveryEmployeeId",
                table: "GuestCards",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeliveryEmployeeId",
                table: "EntranceCards",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeliveryEmployeeId",
                table: "Drawers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeliveryEmployeeId",
                table: "Cabinets",
                type: "uniqueidentifier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryEmployeeId",
                table: "Headsets");

            migrationBuilder.DropColumn(
                name: "DeliveryEmployeeId",
                table: "GuestCards");

            migrationBuilder.DropColumn(
                name: "DeliveryEmployeeId",
                table: "EntranceCards");

            migrationBuilder.DropColumn(
                name: "DeliveryEmployeeId",
                table: "Drawers");

            migrationBuilder.DropColumn(
                name: "DeliveryEmployeeId",
                table: "Cabinets");

            migrationBuilder.RenameColumn(
                name: "ReceiverEmployeeId",
                table: "Headsets",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "ReceiverEmployeeId",
                table: "GuestCards",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "ReceiverEmployeeId",
                table: "EntranceCards",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "ReceiverEmployeeId",
                table: "Drawers",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "ReceiverEmployeeId",
                table: "Cabinets",
                newName: "EmployeeId");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryEmployee",
                table: "Headsets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverEmployee",
                table: "Headsets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryEmployee",
                table: "GuestCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverEmployee",
                table: "GuestCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryEmployee",
                table: "EntranceCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverEmployee",
                table: "EntranceCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryEmployee",
                table: "Drawers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverEmployee",
                table: "Drawers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryEmployee",
                table: "Cabinets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverEmployee",
                table: "Cabinets",
                type: "nvarchar(max)",
                nullable: true);

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
                name: "IX_Cabinets_EmployeeId",
                table: "Cabinets",
                column: "EmployeeId");

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
        }
    }
}
