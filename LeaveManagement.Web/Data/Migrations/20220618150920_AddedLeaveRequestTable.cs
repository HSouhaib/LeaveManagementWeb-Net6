using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a43a43-9f07-4124-957cbbd-c60bb846e7abf",
                column: "ConcurrencyStamp",
                value: "31cedf7a-f247-4e75-b20b-1ea136ffc307");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a4a43-9f07-4124-957d-c60bb846e7bf",
                column: "ConcurrencyStamp",
                value: "0027f977-e82d-4cd6-872e-07fbb345b0a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "654dae5c-6726-4c62-8f4a-70933c2951a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0fede37-eb79-4bda-9c13-6459387badfe", "AQAAAAEAACcQAAAAEPFS2KYqreSohJH3F93Z6j7X4n6sc8fTGcPAitLv3UQC3BkOdPRyQVpwEMm1dZ/G/g==", "4bea5d9e-38f2-47af-857c-aefa2935dceb" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a43a43-9f07-4124-957cbbd-c60bb846e7abf",
                column: "ConcurrencyStamp",
                value: "6b1738a9-c334-4899-bf58-02c025b9c239");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a4a43-9f07-4124-957d-c60bb846e7bf",
                column: "ConcurrencyStamp",
                value: "56c58a3b-8058-4743-bdac-393d8a49e172");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "654dae5c-6726-4c62-8f4a-70933c2951a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2ca728f-ae91-49f9-a47d-a46dfafbc5aa", "AQAAAAEAACcQAAAAEPxMVAeMgDdKGXj3ij8xrkRvi5GWtXsBsxu2k4U+YE09AcB2ZFEcaqYa3t6kfxYR2w==", "d9c7e79f-1f45-480d-9a43-526ce6685426" });
        }
    }
}
