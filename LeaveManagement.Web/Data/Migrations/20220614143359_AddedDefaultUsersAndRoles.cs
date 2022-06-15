using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e4a43a43-9f07-4124-957cbbd-c60bb846e7abf", "c577ef47-67fe-4998-8e02-d9def892e242", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e4a4a43-9f07-4124-957d-c60bb846e7bf", "cc408b7c-36f1-4c9f-82e7-4d4634ff2b84", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TexId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "654dae5c-6726-4c62-8f4a-70933c2951a6", 0, "0fc04cb0-f4f9-477e-a1dc-f38a4e153279", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhot.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEMRFYnbGxvqFGF+lmFoCn4gDivib3Q6WAOp2MzlygDe+hjLnjLC+8JLDQ+uK2u/zhA==", null, false, "120e38ec-6b53-47af-ba99-f6ddbe66a328", null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8e4a4a43-9f07-4124-957d-c60bb846e7bf", "654dae5c-6726-4c62-8f4a-70933c2951a6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a43a43-9f07-4124-957cbbd-c60bb846e7abf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8e4a4a43-9f07-4124-957d-c60bb846e7bf", "654dae5c-6726-4c62-8f4a-70933c2951a6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4a4a43-9f07-4124-957d-c60bb846e7bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "654dae5c-6726-4c62-8f4a-70933c2951a6");
        }
    }
}
